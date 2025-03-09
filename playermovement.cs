using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed = 8f;
    private float move;
    [SerializeField] private Rigidbody2D rb;


    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(speed * move, rb.linearVelocity.y);
     
        
    }
}
