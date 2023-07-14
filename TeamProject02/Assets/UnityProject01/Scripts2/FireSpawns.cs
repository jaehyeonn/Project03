using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpawns : MonoBehaviour
{
    public float speed = 8f;
    public Rigidbody2D fireRigidbody;

   
    private void Start()
    {
        fireRigidbody.velocity = Vector3.left * speed;
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
}
