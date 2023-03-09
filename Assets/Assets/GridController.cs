using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnityEngine;
using System;

public class GridController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Tile;
    public GameObject HLine;
    public GameObject VLine;
    public GameObject Camera;
    public int height, width;
    public GameObject VizTool;
    public GameObject obs;
    GameObject source;
    GameObject destination;


    public List<GameObject> tileList;

    void Start()
    {
        Camera.transform.position = new Vector3(width / 2, height / 2, -10);
        createGrid();
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    void createGrid()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                GameObject tile = Instantiate(Tile, transform.position = new Vector2(i, j), Quaternion.identity);
                tile.name = "tile" + i + "" + j;
                tileList.Add(tile);



                Instantiate(VLine, transform.position = new Vector2(i - 0.5f, j - 0.5f), Quaternion.identity);
                Instantiate(HLine, transform.position = new Vector2(i - 0.5f, j - 0.5f), Quaternion.identity);


            }
        }

    }

    public GameObject SearchTile(Vector2 position)
    {
        try
        {
            for (int i = 0; i < tileList.Count; i++)
            {

                if (tileList[i].transform.position.x == position.x && tileList[i].transform.position.y == position.y)
                {
                    return tileList[i];
                }
            }
        }
        catch
        {
            UnityEngine.Debug.Log("error");
        }

        return null;
    }

    
}

