using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathfinding : MonoBehaviour
{

    float curr_hCost, L_hCost, R_hCost, U_hCost, D_hCost;
    float curr_gCost, L_gCost, R_gCost, U_gCost, D_gCost;





    /////////////////////////////////////

    public GameObject current;
    public GameObject N_left;
    public GameObject N_right;
    public GameObject N_up;
    public GameObject N_down;

    public GameObject destination;

    public place_source place_source_script;
    public GameObject Player;

    public place_dest place_dest_script;
    public GameObject Destination;

    public GridController grid_script;
    public GameObject Grid;

    public cost_finder cost_finder_script;
    public GameObject Cost_Finder;


    // Start is called before the first frame update
    void Start()
    {
        place_source_script = Player.GetComponent<place_source>();
        place_dest_script = Destination.GetComponent<place_dest>();
        grid_script = Grid.GetComponent<GridController>();
        cost_finder_script = Cost_Finder.GetComponent<cost_finder>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Find_Path()
    {
        current = grid_script.SearchTile(place_source_script.source_pos);
        N_left = grid_script.SearchTile(place_source_script.source_pos + new Vector2(-1, 0));
        N_right = grid_script.SearchTile(place_source_script.source_pos + new Vector2(1, 0));
        N_up = grid_script.SearchTile(place_source_script.source_pos + new Vector2(0, 1));
        N_down = grid_script.SearchTile(place_source_script.source_pos + new Vector2(0, -1));
        destination = grid_script.SearchTile(place_dest_script.dest_pos);

        curr_hCost = Mathf.Abs(cost_finder_script.h_cost((Vector2)current.transform.position,place_dest_script.dest_pos));
        L_hCost = Mathf.Abs(cost_finder_script.h_cost((Vector2)N_left.transform.position, place_dest_script.dest_pos));
        R_hCost = Mathf.Abs(cost_finder_script.h_cost((Vector2)N_right.transform.position, place_dest_script.dest_pos));
        U_hCost = Mathf.Abs(cost_finder_script.h_cost((Vector2)N_up.transform.position, place_dest_script.dest_pos));
        D_hCost = Mathf.Abs(cost_finder_script.h_cost((Vector2)N_down.transform.position, place_dest_script.dest_pos));

        curr_gCost = cost_finder_script.g_cost(place_source_script.source_pos, (Vector2)current.transform.position);
        L_gCost = cost_finder_script.g_cost(place_source_script.source_pos, (Vector2)N_left.transform.position);
        R_gCost = cost_finder_script.g_cost(place_source_script.source_pos, (Vector2)N_right.transform.position);
        U_gCost = cost_finder_script.g_cost(place_source_script.source_pos, (Vector2)N_up.transform.position);
        D_gCost = cost_finder_script.g_cost(place_source_script.source_pos, (Vector2)N_down.transform.position);


        UnityEngine.Debug.Log((Vector2)current.transform.position);
        UnityEngine.Debug.Log(N_left.transform.position);
        UnityEngine.Debug.Log(N_right.transform.position);
        UnityEngine.Debug.Log(N_up.transform.position);
        UnityEngine.Debug.Log(N_down.transform.position);
        UnityEngine.Debug.Log(place_dest_script.dest_pos);

        //For Checking : 
        UnityEngine.Debug.Log("For the current tile : "+ curr_gCost + "+"+curr_hCost);
        UnityEngine.Debug.Log("For the Left tile : "+ L_gCost + "+" + L_hCost);
        UnityEngine.Debug.Log("For the Right tile : "+ R_gCost + "+" + R_hCost);
        UnityEngine.Debug.Log("For the Upper tile : "+ U_gCost + "+" + U_hCost);
        UnityEngine.Debug.Log("For the Lower tile : "+ D_gCost + "+" + D_hCost);
        //


        //UnityEngine.Debug.Log(current.transform.position.x + "," + current.transform.position.y + " & " + place_source_script.source_pos.x+"," + place_source_script.source_pos.y);
        //roughVisual_script.rough_visual(current_pos,N_left_pos,N_right_pos,N_up_pos,N_down_pos);
        //UnityEngine.Debug.Log("hah");
    }

 
}
