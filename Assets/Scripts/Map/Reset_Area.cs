using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset_Area : MonoBehaviour
{
    [SerializeField] public Transform resetPoint;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.position = resetPoint.position;
        }
    }
}
