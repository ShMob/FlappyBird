using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    private float horizontalMoveAmount;
    public float x_start = 2.65f, x_end = -2.72f;
    void Start()
    {
        horizontalMoveAmount = FindObjectOfType<BirdController>().horizontalMoveAmount;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.x < x_end)
        {
            transform.position = new Vector3(x_start, transform.position.y, transform.position.z);
        }
        transform.position = new Vector3(transform.position.x - horizontalMoveAmount, transform.position.y, transform.position.z);
    }
}
