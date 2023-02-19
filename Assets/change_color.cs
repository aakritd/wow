using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_color : MonoBehaviour
{
     SpriteRenderer rend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void set_color(Color col,GameObject gameObject)
    {
        rend = gameObject.GetComponent<SpriteRenderer>();
        rend.color = col;
    }

}
