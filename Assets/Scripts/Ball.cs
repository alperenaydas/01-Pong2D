using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-1, Random.Range(-1f, 1f))*speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Paddle"))
        {
            rb.velocity = collision.GetContact(0).normal.magnitude * rb.velocity * 1.005f;
        }
        else
        {
            rb.velocity = rb.velocity * 1.005f;
        }
    }
}
