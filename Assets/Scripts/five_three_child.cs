using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class five_three_child : MonoBehaviour
{
    public float speed = 5f;
    public float maxX = 3f;
    public float minX = -3f;
    private Vector3 v;
    private bool left = true;

    void Start()
    {
        transform.localPosition = new Vector3(0f, 0f, 0f);
        v = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        float sx = speed * Time.deltaTime;
        if (left)
        {
            v.x -= sx;
            if(v.x <= minX)
            {
                v.x = minX;
                left = false;
            }
        }
        else
        {
            v.x += sx;
            if(v.x >= maxX)
            {
                v.x = maxX;
                left = true;
            }
        }
        transform.localPosition = v;
    }
}
