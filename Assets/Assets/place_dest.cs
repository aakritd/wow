using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class place_dest : MonoBehaviour
{
    Vector2 position;
    public GameObject destination;
    public GameObject Self;
    private int count = 0;
    public Vector2 dest_pos;

    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (count == 0)
            {
                Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                spawnPosition.z = -0.1f;
                GameObject dest = Instantiate(destination, (Vector2)spawnPosition, Quaternion.identity);
                dest.transform.position = new Vector2(Mathf.Round(spawnPosition.x), Mathf.Round(spawnPosition.y));
                Self.transform.position = dest.transform.position;
                dest_pos = dest.transform.position;
                Self.SetActive(false);
                count++;
            }

        }
    }
}
