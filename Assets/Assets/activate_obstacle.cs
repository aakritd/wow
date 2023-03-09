using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate_obstacle : MonoBehaviour
{
    public GameObject obs;
    public GameObject source;
    private bool key = false;
    void Start()
    {
        obs.SetActive(false);
    }
    public void ButtonPressedObstacle()
    {
        key = !key;
        obs.SetActive(key);         
    }

    public void ButtonPressedSource()
    {
        source.SetActive(false);
    } 
}