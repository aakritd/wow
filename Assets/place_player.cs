using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class place_player : MonoBehaviour
{
    Vector2 position;
    public GameObject player;
    public GameObject Self;
    private int count=0;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(count == 0)
            {
                Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                spawnPosition.z = -0.1f;
                GameObject p = Instantiate(player, (Vector2)spawnPosition, Quaternion.identity);
                p.transform.position = new Vector2((int)spawnPosition.x + 0.5f, (int)spawnPosition.y + 0.5f);
                
                Self.SetActive(false);
            }
            
        }
    }
}
