using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    public Transform ball;
    private Rigidbody2D ballRb;

    private Rigidbody2D aiRb;

    public float force;
    
    // Start is called before the first frame update
    void Start()
    {
        ballRb = ball.GetComponent<Rigidbody2D>();
        aiRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ballRb.velocity.x > 0)
        {
            if (ball.position.y > transform.position.y)
            {
                aiRb.AddForce(Vector2.up * force);
            }
            else
            {
                aiRb.AddForce(Vector2.down * force);
            }
        }
        else
        {
            if (transform.position.y > 0)
            {
                aiRb.AddForce(Vector2.down * force);
            }
            else
            {
                aiRb.AddForce(Vector2.up * force);
            }
        }
    }
    
    
}
