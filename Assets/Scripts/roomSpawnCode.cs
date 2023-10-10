using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomSpawnCode : MonoBehaviour
{
    public GameObject[] rooms;
    // Start is called before the first frame update
    void Start()
    {
        int newLevel = Random.Range(0, rooms.Length);
        Instantiate(rooms[newLevel], transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
