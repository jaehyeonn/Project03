using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firemove : MonoBehaviour
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
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Player player = collision.GetComponent<Player>();

            if(player != null)
            {
                player.Die();
            }
        }
    }
}
