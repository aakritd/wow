using System;
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

    public int cost(Vector2 initial, Vector2 final)
    {
        try
        {
            int Cost;

            Vector2 resultant;
            resultant = final - initial;
            Cost = (int)(Mathf.Abs(resultant.x) + Mathf.Abs(resultant.y));
            return Cost;
        }
        catch(NullReferenceException)
        {
            UnityEngine.Debug.Log("cant find cost");
        }
        return 100;
        
    }
    
}
