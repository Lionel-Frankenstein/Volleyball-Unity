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
            rb.velocity = newVelocity * 5;
        }
        if(collision.gameObject.name == "Opponent"){
            Rigidbody2D collisionRb = collision.gameObject.GetComponent<Rigidbody2D>();
            Vector2 newVelocity = new Vector2(-1.5f, 1.5f);
            rb.velocity = newVelocity * 5;
        }
        if(collision.gameObject.name == "LeftWall"){
            rb.velocity = new Vector2(-7, rb.velocity.y);
            Debug.Log("Here");
        }
        if(collision.gameObject.name == "RightWall"){
            rb.velocity = new Vector2(-7, rb.velocity.y);
        }
        if(collision.gameObject.name == "Ceiling"){
            rb.velocity = new Vector2(rb.velocity.x, -7);

        }
    }
}
