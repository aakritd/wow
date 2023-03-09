using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_path_script : MonoBehaviour
{
    public change_color change_color_script;
    public GameObject change_color_obj;


    public class node_2
    {
        public GameObject tile;
        public node_2 next;

        public node_2(GameObject t)
        {
            tile = t;
        }
        
    };

    public node_2 head2 = null;
    public void add_node_in_main_list(GameObject t)
    {
        node_2 n = new node_2(t);
        if (head2 == null)
        {
            head2 = n;
            return;
        }
        node_2 temp = head2;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = n;
        //if final = destination;
    }

    public void rough_Visual()
    {
        node_2 temp = head2;
        while(temp.next != null)
        {
            change_color_script.set_color(Color.red, temp.tile);
            temp = temp.next;
        }
    }

    public void display()
    {
        node_2 temp = head2;
        while(temp != null)
        {
            UnityEngine.Debug.Log(temp.tile.transform.position);
            temp = temp.next;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        change_color_script = change_color_obj.GetComponent<change_color>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
