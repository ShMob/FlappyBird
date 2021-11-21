using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpAmount;
    Rigidbody2D rb;
    public float horizontalMoveAmount;
    private UiManager uiManager;
    private float velocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        uiManager = FindObjectOfType<UiManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, jumpAmount), ForceMode2D.Impulse);
        }
        //transform.position = new Vector3(transform.position.x, transform.position.y + velocity, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        uiManager.Lose();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        uiManager.IncreaseScore();
        
    }
}
