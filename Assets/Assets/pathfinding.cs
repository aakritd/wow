using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathfinding : MonoBehaviour
{
    /////////////////////////////////////

    public int curr_Cost, R_Cost, L_Cost, U_Cost, D_Cost;

    public GameObject N_left;
    public GameObject N_right;
    public GameObject N_up;
    public GameObject N_down;

    public GameObject destination;
    public GameObject current;

    public place_source place_source_script;
    public GameObject Player;

    public place_dest place_dest_script;
    public GameObject Destination;

    public GridController grid_script;
    public GameObject Grid;

    public cost_finder cost_finder_script;
    public GameObject Cost_Finder;

    public priority_queue priority_queue_script;
    public GameObject Priority_Queue;


    public visited_tiles_list visited_tiles_script;
    public GameObject Visited_Tiles;

    public Final_Path_List final_path_script;
    public GameObject Final_Path;

    int num = 0;
    // Start is called before the first frame update
    void Start()
    {
        place_source_script = Player.GetComponent<place_source>();
        place_dest_script = Destination.GetComponent<place_dest>();
        grid_script = Grid.GetComponent<GridController>();
        cost_finder_script = Cost_Finder.GetComponent<cost_finder>();
        priority_queue_script = Priority_Queue.GetComponent<priority_queue>();
        visited_tiles_script = Visited_Tiles.GetComponent<visited_tiles_list>();
        final_path_script = Final_Path.GetComponent<Final_Path_List>();



    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Find_Path()
    {
        current = grid_script.SearchTile(place_source_script.source_pos);



        destination = grid_script.SearchTile(place_dest_script.dest_pos);

        do
        {
            visited_tiles_script.add_in_explored_tiles(current);

            curr_Cost = cost_finder_script.cost((Vector2)current.transform.position, place_source_script.source_pos);

            priority_queue_script.enqueue(current, curr_Cost);
            //UnityEngine.Debug.Log("woww");




            N_left = grid_script.SearchTile((Vector2)current.transform.position + new Vector2(-1, 0));
            
            if (N_left != null && !visited_tiles_script.check_in_explored_tiles(N_left) )
            {
                visited_tiles_script.add_in_explored_tiles(N_left);
                L_Cost = Mathf.Abs(cost_finder_script.cost((Vector2)N_left.transform.position, place_source_script.source_pos));
                priority_queue_script.enqueue(N_left, L_Cost);
                final_path_script.add_node(current, N_left);
            }

            N_right = grid_script.SearchTile((Vector2)current.transform.position + new Vector2(1, 0));
            if (N_right != null && !visited_tiles_script.check_in_explored_tiles(N_right))
            {
                visited_tiles_script.add_in_explored_tiles(N_right);
                R_Cost = Mathf.Abs(cost_finder_script.cost((Vector2)N_right.transform.position, place_source_script.source_pos));
                priority_queue_script.enqueue(N_right, R_Cost);
                final_path_script.add_node(current, N_right);
            }

            N_up = grid_script.SearchTile((Vector2)current.transform.position + new Vector2(0, 1));
            if (N_up != null &&  !visited_tiles_script.check_in_explored_tiles(N_up))
            {
                visited_tiles_script.add_in_explored_tiles(N_up);
                U_Cost = Mathf.Abs(cost_finder_script.cost((Vector2)N_up.transform.position, place_source_script.source_pos));
                priority_queue_script.enqueue(N_up, U_Cost);
                final_path_script.add_node(current, N_up);
            }


            N_down = grid_script.SearchTile((Vector2)current.transform.position + new Vector2(0, -1));
            if (N_down != null &&  !visited_tiles_script.check_in_explored_tiles(N_down))
            {
                visited_tiles_script.add_in_explored_tiles(N_down);
                D_Cost = Mathf.Abs(cost_finder_script.cost((Vector2)N_down.transform.position, place_source_script.source_pos));
                priority_queue_script.enqueue(N_down, D_Cost);
                final_path_script.add_node(current, N_down);
            }

            UnityEngine.Debug.Log(curr_Cost);
            UnityEngine.Debug.Log(L_Cost);
            UnityEngine.Debug.Log(R_Cost);
            UnityEngine.Debug.Log(U_Cost);
            UnityEngine.Debug.Log(D_Cost);
            current = priority_queue_script.dequeue();
            num++;
        } while ((Vector2)current.transform.position != (Vector2)destination.transform.position);
        // } while (num != 30);

        final_path_script.add_to_main_list();
    }
}
