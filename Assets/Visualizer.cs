using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visualizer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject source;
    public GameObject destination;
    float x1,y1, x2, y2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void visualize()
    {
        x1=source.transform.position.x;
        y1=source.transform.position.y;
        x2=destination.transform.position.x;
        y2=destination.transform.position.y;
        
    }

}
