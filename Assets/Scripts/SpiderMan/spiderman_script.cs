using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderman_script : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed = 3;
    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}


