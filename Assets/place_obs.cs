using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class place_obs : MonoBehaviour
{
    Vector2 position;
    public GameObject Obstacle;



    // Update is called once per frame
    void Update()
    {



        if (Input.GetMouseButtonDown(0))
        {
            Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject O = Instantiate(Obstacle, (Vector2)spawnPosition, Quaternion.identity);
            O.transform.position=new Vector2((int)spawnPosition.x+0.5f,(int)spawnPosition.y+0.5f);


        }
    }
}
