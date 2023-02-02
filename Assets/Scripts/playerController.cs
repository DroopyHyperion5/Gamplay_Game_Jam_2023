using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float pSpeed = 10f;
    public float jForce;
    protected bool pJump = true;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {

    }

    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(xMove * pSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && pJump == true)
        {
            rb.AddForce(Vector2.up * jForce, ForceMode2D.Impulse);
        }
    }
}
