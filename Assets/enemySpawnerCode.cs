using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawnerCode : MonoBehaviour
{
    public GameObject[] enems;
    // Start is called before the first frame update
    void Start()
    {
        int newEnem = Random.Range(0, enems.Length+1);
        if(newEnem != enems.Length)
        {
            Instantiate(enems[newEnem], transform.position, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
