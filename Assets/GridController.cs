using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Tile;
    public GameObject HLine;
    public GameObject VLine;
    public GameObject Camera;
    public int height, width;

    void Start()
    {
        Camera.transform.position = new Vector3(width / 2, height / 2,-10);
        createGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void createGrid()
    {
        for (float i = 0; i < width; i++)
        {
            for (float j = 0; j < height; j++)
            {
                GameObject tile=Instantiate(Tile, transform.position = new Vector2(i, j), Quaternion.identity);
                tile.name = "tile" + i + "" + j;
                Instantiate(VLine, transform.position = new Vector2(i, j), Quaternion.identity);
                Instantiate(HLine, transform.position = new Vector2(i, j), Quaternion.identity);
            }
        }
    }
}
