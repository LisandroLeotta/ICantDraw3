using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float JumpPow = 16f;
    private bool derecha = true;
    public Dialogo QuintoDialogo;

    

    [SerializeField] private Rigidbody2D RB;
    [SerializeField] private Transform groundcheck;
    [SerializeField] private LayerMask GroundLayer;

  


    void Update()
    {
       

        if (QuintoDialogo.QuintoDialogo == false)
        {

            horizontal = Input.GetAxisRaw("Horizontal");

            flip();

            if (Input.GetButtonDown("Jump") && IsGrounded())
            {
                RB.velocity = new Vector2(RB.velocity.x, JumpPow);
            }

            if (Input.GetButtonDown("Jump") && RB.velocity.y > 0f)
            {
                RB.velocity = new Vector2(RB.velocity.x, RB.velocity.y * 0.5f);
            }
        }

        if (QuintoDialogo.QuintoDialogo == true)
        {
            horizontal = 0f;
        }


    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundcheck.position, 0.2f, GroundLayer);
    }

    private void FixedUpdate()
    {
        RB.velocity = new Vector2(horizontal * speed, RB.velocity.y);
    }

    private void flip()
    {
        if (derecha && horizontal < 0f  || !derecha && horizontal > 0f)
        {
            derecha = !derecha;
            Vector3 localscale = transform.localScale;
            localscale.x *= -1f;
            transform.localScale = localscale;
        }
    }
}
