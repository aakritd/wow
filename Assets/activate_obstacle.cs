using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate_obstacle : MonoBehaviour
{
    public GameObject obs;
    private bool key = false;
    void Start()
    {
        obs.SetActive(false);
    }
    public void ButtonPressed()
    {
        key = !key;
        obs.SetActive(key);         
    }
    void Update()
    {
        
    }    
}