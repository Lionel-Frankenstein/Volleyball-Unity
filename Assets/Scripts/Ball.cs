using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    string lastTouch;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.name == "Player"){
            Rigidbody2D collisionRb = collision.gameObject.GetComponent<Rigidbody2D>();
            Vector2 newVelocity = new Vector2(1.5f, 1.5f);
            rb.velocity = newVelocity;
        }
        if(collision.gameObject.name == "Oppopnent"){
            Rigidbody2D collisionRb = collision.gameObject.GetComponent<Rigidbody2D>();
            Vector2 newVelocity = new Vector2(-1.5f, 1.5f);
            rb.velocity = newVelocity;
        }
    }
}
