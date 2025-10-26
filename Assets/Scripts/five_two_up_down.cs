using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class five_two_up_down : MonoBehaviour
{
    public float speed = 5f;
    public float maxY = 3f;
    public float minY = -3f;
    private Vector3 v;
    private bool up = true;
    //private Vector3 localOffset = new Vector3(0f, 0f, 0f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        v = transform.localPosition;// + localOffset;
    }

    // Update is called once per frame
    void Update()
    {
        float sy = speed * Time.deltaTime;
        if (up)
        {
            v.y += sy;
            if (v.y >= maxY)
            {
                v.y = maxY;
                up = false;
            }
        }
        else
        {
            v.y -= sy;
            if (v.y <= minY)
            {
                v.y = minY;
                up = true;
            }
        }
        transform.localPosition = v;
    }
}
