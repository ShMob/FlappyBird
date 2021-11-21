using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePlacer : MonoBehaviour
{
    public GameObject Pipe;
    public float MaxY, MinY;
    public float maxTimer;
    private float timer;
    void Start()
    {
        timer = maxTimer;
    }

    // Update is called once per frame
    void Update()
    {
        --timer;
        if (timer <= 0)
        {
            timer = maxTimer;
            GameObject p = Instantiate(Pipe);
            p.transform.position = new Vector3(transform.position.x, GetRandomY(), 0);
        }
    }

    private float GetRandomY()
    => UnityEngine.Random.Range(MinY, MaxY);
}
