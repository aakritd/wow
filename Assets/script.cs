using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
     public GameObject dotPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject g = Instantiate(dotPrefab, (Vector2)spawnPosition, Quaternion.identity);
            g.transform.position = new Vector2((int)spawnPosition.x+0.5f,(int)spawnPosition.y+0.5f);
        }
    }
}
