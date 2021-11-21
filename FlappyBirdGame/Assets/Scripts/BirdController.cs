using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpAmount;
    Rigidbody2D rb;
    public float verticalMoveAmount;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, jumpAmount), ForceMode2D.Impulse);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<UiManager>().Lose();
    }
}
