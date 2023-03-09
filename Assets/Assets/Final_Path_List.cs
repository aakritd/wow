using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final_Path_List : MonoBehaviour
{
    public main_path_script main_path_list_script;
    public GameObject Main_Path_List;


    public class node_1
    {
        public GameObject final, initial;
        public node_1 next;
        public node_1 prev;

        public node_1(GameObject t_initial,GameObject t_final)
        {
            initial = t_initial;
            final = t_final;
            
            next = null;
            prev = null;
        }
        
           
    };
    
    node_1 head = null;

    public void add_node(GameObject t_initial, GameObject t_final)
    {
        node_1 n = new node_1(t_initial, t_final);
        if (head == null)
        {
            head = n;
            UnityEngine.Debug.Log("Node Added.");
            return;
        }
        node_1 temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = n;
        n.prev = temp;
        UnityEngine.Debug.Log("Node Added.");
        //if final = destination;
    }

    public void add_to_main_list()
    {
        node_1 temp = head;
        while(temp.next != null)
        {
            temp = temp.next;
        }
        while(temp.prev != null)
        {
            temp = temp.prev;
            main_path_list_script.add_node_in_main_list(temp.final);
            main_path_list_script.add_node_in_main_list(temp.initial);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        main_path_list_script = Main_Path_List.GetComponent<main_path_script>();
    }

    // Update is called once per frame
    void Update()
    {

    } 

    



}
