using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roughVisual : MonoBehaviour
{







    /////////////////////////////////////

    public GameObject current;
    public GameObject N_left;
    public GameObject N_right;
    public GameObject N_up;
    public GameObject N_down;

    public place_source place_source_script;
    public GameObject Player;

    public place_dest place_dest_script;
    public GameObject Destination;

    public GridController grid_script;
    public GameObject Grid;

    public change_color change_color_script;
    public GameObject change_color_obj;

    // Start is called before the first frame update
    void Start()
    {
        place_source_script = Player.GetComponent<place_source>();
        place_dest_script = Destination.GetComponent<place_dest>();
        grid_script = Grid.GetComponent<GridController>();
        change_color_script = change_color_obj.GetComponent<change_color>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Visualize()
    {


        current = grid_script.SearchTile(place_source_script.source_pos);
        N_left = grid_script.SearchTile(place_source_script.source_pos + new Vector2(-1, 0));
        N_right = grid_script.SearchTile(place_source_script.source_pos + new Vector2(1, 0));
        N_up = grid_script.SearchTile(place_source_script.source_pos + new Vector2(0, 1));
        N_down = grid_script.SearchTile(place_source_script.source_pos + new Vector2(0, -1));

        change_color_script.set_color(Color.red,current);
        change_color_script.set_color(Color.yellow, N_left);
        change_color_script.set_color(Color.yellow, N_right);
        change_color_script.set_color(Color.yellow, N_up);
        change_color_script.set_color(Color.yellow, N_down);


        //UnityEngine.Debug.Log(current.transform.position.x + "," + current.transform.position.y + " & " + place_source_script.source_pos.x+"," + place_source_script.source_pos.y);
        //roughVisual_script.rough_visual(current_pos,N_left_pos,N_right_pos,N_up_pos,N_down_pos);
        //UnityEngine.Debug.Log("hah");
    }
}
