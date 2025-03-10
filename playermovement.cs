using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed;
    public float jump;
    private float move;
    public bool isjumping;
    [SerializeField] private Rigidbody2D rb;


    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(speed * move, rb.linearVelocity.y);

        if (Input.GetButtonDown("Jump") && isjumping==false)
        {
            rb.AddForce(new Vector2(rb.linearVelocity.x, jump));
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if( other.gameObject.CompareTag("Ground"))
            { isjumping = false; }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        { isjumping = true; }
    }
}
