using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate_player:MonoBehaviour
{
    public GameObject Player;
    private bool key = false;
    
    // Start is called before the first frame update
    void Start()
    {
      
     Player.SetActive(key);
    }
    void Update()
    {

    }
    public void ButtonPressed()
    {
        key = !key;
        Player.SetActive(key);
    }
}
