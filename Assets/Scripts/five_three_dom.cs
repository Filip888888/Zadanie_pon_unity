using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class five_three_dom : MonoBehaviour
{
    private Vector3 v;
    public float maxZ = 3f;
    public float minZ = -3f;
    public float speed = 5f;
    public bool forward = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //transform.localPosition = new Vector3(-2.56f, 1.01f, -9.94738f);
        transform.position = new Vector3(-2.56f, 1.01f, -9.94738f);
        //v = transform.localPosition;
        v = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float sz = speed * Time.deltaTime;
        if (forward)
        {
            v.z += sz;
            if(v.z >= maxZ)
            {
                v.z = maxZ;
                forward = false;
            }
        }
        else
        {
            v.z -= sz;
            if(v.z <= minZ)
            {
                v.z = minZ;
                forward = true;
            }
        }
        //transform.localPosition = v;
        transform.position= v;
    }
}
