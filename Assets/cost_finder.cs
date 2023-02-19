using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cost_finder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float h_cost(Vector2 source, Vector2 final)
    {
        float h_Cost;

        Vector2 resultant;
        resultant = final - source;
        h_Cost = Mathf.Abs(resultant.x) + Mathf.Abs(resultant.y);
        return h_Cost;
    }


    public float g_cost(Vector2 initial,Vector2 final)
    {
        float g_Cost;

        Vector2 resultant;
        resultant = final - initial; 
        g_Cost = Mathf.Abs(resultant.x) + Mathf.Abs(resultant.y);
        return g_Cost;
    }
    
}
