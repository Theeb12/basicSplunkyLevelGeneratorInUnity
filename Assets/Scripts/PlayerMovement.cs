using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float speed = 5;
    bool grounded = false;
    float jumpHeight = 5;
    SpriteRenderer sprRend;
    // Start is called before the first frame update
    void Start()
    {
        sprRend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
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
        }
        else if(inputX > 0)
        {
            sprRend.flipX = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Platform"))
        {
            grounded = true;
        }
    }
}
