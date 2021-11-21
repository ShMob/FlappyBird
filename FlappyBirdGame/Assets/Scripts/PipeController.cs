using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    private float moveAmount;
    // Start is called before the first frame update
    void Start()
    {
        moveAmount = FindObjectOfType<BirdController>().horizontalMoveAmount;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x - moveAmount, transform.position.y, transform.position.z);
        if(transform.position.x < -10)
        {
            Destroy(this.gameObject);
        }
    }
}
