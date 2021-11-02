using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2d;
    public float BallPos;
    public float SpeedMultiplier;

    void GoBall()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb2d.AddForce(new Vector2(20, -15));
        }
        else
        {
            rb2d.AddForce(new Vector2(-20, -15));
        }
    }

    void ResetBall()
    {
        rb2d.velocity = Vector2.zero;
        transform.position = Vector2.zero;
        Invoke("GoBall", 1);
    }

    void ResetGame()
    {
        ResetBall();
        Invoke("GoBall", 1);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player")) 
        {
            Vector2 vel;
            vel.x = rb2d.velocity.x * SpeedMultiplier;
            vel.y = rb2d.velocity.y * SpeedMultiplier;
            rb2d.velocity = vel;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    }

    // Update is called once per frame
    void Update()
    {
        BallPos = gameObject.transform.position.y;
    }
}
