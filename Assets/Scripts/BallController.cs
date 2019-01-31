using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float upForce;
    Rigidbody2D rb;
    bool isStarted;
    bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isStarted = false;
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isStarted)
        {
            if (Input.GetMouseButtonDown(0))
            {
                isStarted = true;
                rb.isKinematic = false;
                GameManager.instance.GameStart();
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(0, upForce));
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        isGameOver = true;
        GameManager.instance.GameOver();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Pipe" && !isGameOver)
        {
            isGameOver = true;
            GameManager.instance.GameOver();
        }

        if(col.gameObject.tag == "ScoreChecker" && !isGameOver)
        {
            ScoreManager.instance.IncrementScore();
        }
    }
}
