using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visited_tiles_list : MonoBehaviour
{
    GameObject[] explored_tiles = new GameObject[1000000];
    int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void add_in_explored_tiles(GameObject t)
    {
        explored_tiles[index++] = t;
        UnityEngine.Debug.Log("Tile Added in Visited List.");
    }

    public bool check_in_explored_tiles(GameObject t)
    {
        for(int i = 0;i<index;i++)
        {
            if(explored_tiles[i] == t)
            {
                return true;
            }
        }
        return false;
    }
}
