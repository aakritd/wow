using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class priority_queue : MonoBehaviour
{
    
    GameObject temp_tile;
    
    public LinkedList<GameObject> linked_list_tiles = new LinkedList<GameObject>();
    

        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void enqueue(GameObject tiles,int p)
        {   
            try
            {
            linked_list_tiles.AddLast(tiles);
            UnityEngine.Debug.Log("done enqueue");
            return;
            }
            catch (NullReferenceException)
            {
            UnityEngine.Debug.Log("cannot enqueue");
            }
            return;

        }

    public GameObject dequeue()
        {

            int i = 0;
       
            try
            {

           // while (linked_list_tiles.Count != 0)
            //{
             //   i++;
            //}
            temp_tile = linked_list_tiles.First.Value;
            linked_list_tiles.RemoveFirst();
            return temp_tile;
            }
            catch
            {
                UnityEngine.Debug.Log("no tile in the queue");
            }
            return null;    

        }
}
