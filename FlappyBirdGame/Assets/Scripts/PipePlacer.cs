using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePlacer : MonoBehaviour
{
    public GameObject Pipe;

    public float maxTimer;
    private float timer;
    void Start()
    {
        timer = maxTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (--timer <= 0)
        {
            Debug.Log("Here");
            GameObject p = Instantiate(Pipe);
            p.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
        else
        {
            timer = maxTimer;
        }
    }
}
