using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport2 : MonoBehaviour
{
    public float yBound;
    public float ySpawn = 5f;
    public float Lowx = 5f;
    public float Highx = 5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ResetPosition();

    }

    void ResetPosition()
    {
        if (transform.position.y < yBound)
        {
            Vector3 NewPosition = transform.position;
            NewPosition.y = ySpawn;
            NewPosition.x = Random.Range(Lowx, Highx);

            transform.position = NewPosition;

            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
