﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Brick : MonoBehaviour
{

    public float point;
    
    // Start is called before the first frame update
    void Start()
    {
       point = ConfigurationUtils.StandardBrickPoint; 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {

            HUD.addScore(point);      
            Destroy(gameObject);
        }
    }

   
}
