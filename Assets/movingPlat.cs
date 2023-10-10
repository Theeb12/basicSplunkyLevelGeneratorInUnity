using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlat : MonoBehaviour
{
    Vector3 direction = Vector3.left;
    float speed = 3f;
    float startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
        if (direction == Vector3.left && transform.position.x <= startPos-4.3)
        {
            direction = Vector3.right;
        }
        else if(direction == Vector3.right && transform.position.x >= startPos)
        {
            direction = Vector3.left;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.SetParent(transform);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }
}
