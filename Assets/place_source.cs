using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class place_source: MonoBehaviour
{
    Vector2 position;
    public GameObject source;
    public GameObject Self;
    private int count=0;
    public Vector2 source_pos;

    void Start()
    {
        //source.transform.position = new Vector2(0, 0);
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
                GameObject src = Instantiate(source, (Vector2)spawnPosition, Quaternion.identity);
                src.transform.position = new Vector2(Mathf.Round(spawnPosition.x), Mathf.Round(spawnPosition.y));
                Self.transform.position = src.transform.position;
                source_pos = src.transform.position;
                count++;
                Self.SetActive(false);
            }
        }
    }
}
