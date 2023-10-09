using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //float speed = 5;
    bool grounded = false;
    float jumpHeight = 5;
    SpriteRenderer sprRend;
    Rigidbody2D _rigidbody;

    //dash ability
    private bool dash_performed;
    private float dashTimer;
    private float dashPower = 8;
    private float dashcdTimer;

    //movement control
    private float xSpeed;


    // Start is called before the first frame update
    void Start()
    {
        sprRend = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();
        dash_performed = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        float inputX = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(speed * inputX, 0, 0);
        transform.Translate(move * Time.deltaTime);
        if (Input.GetKeyDown("space") && grounded)
        {
            // Debug.Log("jumped");
            grounded = false;
            //gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * jumpHeight, ForceMode2D.Impulse);
            gameObject.GetComponent<Rigidbody2D>().velocity += new Vector2(0, jumpHeight);
        }
        if(inputX < 0)
        {
            sprRend.flipX = true;
            //transform.localScale.x *= new Vector2(-1, 1);
        }
        else if(inputX > 0)
        {
            sprRend.flipX = false;
        }
        */
        
        if (PublicVariables.dash_enable)
        {
            dash();
        }
        movement();
    }

    void movement()
    {
        /*
        xSpeed = Input.GetAxisRaw("Horizontal") * PublicVariables.player_speed;

        if((xSpeed < 0 && transform.localScale.x > 0) || (xSpeed > 0 && transform.localScale.x < 0))
        {
            transform.localScale *= new Vector2(-1,1);
        }
        //print(Time.fixedDeltaTime);
        _rigidbody.velocity = new Vector2(xSpeed, _rigidbody.velocity.y);
        */
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        Vector3 scale = transform.localScale;
        if (horizontalInput > 0)
        {
            scale.x = Math.Abs(scale.x);
        }
        if (horizontalInput < 0)
        {
            scale.x = -1 * Math.Abs(scale.x);
        }
        transform.localScale = scale;
        _rigidbody.AddForce(new Vector2(horizontalInput, 0), ForceMode2D.Impulse);
        if (!dash_performed)
        {
            if (Math.Abs(_rigidbody.velocity.x) > PublicVariables.player_speed)
            {
                _rigidbody.velocity = new Vector2(Mathf.Sign(_rigidbody.velocity.x) * PublicVariables.player_speed, _rigidbody.velocity.y);
            }
        }

    }

    void dash()
    {
        if (!dash_performed)
        {
            if (Input.GetKeyDown("z") && dashcdTimer > PublicVariables.dashcd)
            {
                dash_performed = true;
                _rigidbody.velocity = new Vector2(Math.Sign(transform.localScale.x) * dashPower, 0);
                dashTimer = 0f;
                _rigidbody.gravityScale = 0;
                dashcdTimer = 0;
            }
        }
        else
        {
            dashTimer += Time.deltaTime;
            if (dashTimer > PublicVariables.dashLimit)
            {
                dash_performed = false;
                _rigidbody.gravityScale = 1;
            }
        }
        dashcdTimer += Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Platform"))
        {
            grounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Platform"))
        {
            grounded = false;
        }
    }
}
