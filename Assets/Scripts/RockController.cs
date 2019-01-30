using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    public float speed;
    public float upDownSpeed;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        MoveRock();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveRock()
    {
        rb.velocity = new Vector2(-speed, 0);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "RockRemover")
        {
            Destroy(gameObject);
        }
    }
}
