using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class five_two : MonoBehaviour
{
    public float speed = 5f;
    public float maxX = 3f;
    public float minX = -3f;
    private Vector3 v;
    private bool right = true;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        v = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        float sx = speed * Time.deltaTime;
        if (right)
        {
            v.x += sx;
            if(v.x >= maxX)
            {
                v.x = maxX;
                right = false;
            }
        }
        else
        {
            v.x -= sx;
            if (v.x <= minX)
            {
                v.x = minX;
                right = true;
            }
        }
        transform.localPosition = v;
    }
}
