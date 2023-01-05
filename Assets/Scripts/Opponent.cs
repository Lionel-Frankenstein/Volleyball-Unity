using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opponent : MonoBehaviour
{
    public float speed = 8f;
    public float jumpFofce = 8f;

    Rigidbody2D rb;
    bool isOnGround;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isOnGround = false;
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("HorizontalP2");
        Vector2 movement = new Vector2(xInput * speed * Time.deltaTime, 0);
        transform.Translate(movement);
        if(Input.GetKeyDown(KeyCode.UpArrow) && isOnGround){
            rb.AddForce(Vector2.up * jumpFofce, ForceMode2D.Impulse);
            isOnGround = false;
        }
    }
    
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.name == "Ground"){
            isOnGround = true;
        }
    }
}
