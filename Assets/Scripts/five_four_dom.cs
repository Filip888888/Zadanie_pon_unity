using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class five_four_dom : MonoBehaviour
{

    public float speed = 10f;
    public float maxZ = 5f;
    public float minZ = -5f;
    private Vector3 v;
    private bool forward = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(2f, 2f, 2f);
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
            if (v.z <= minZ)
            {
                v.z = minZ;
                forward = true;
            }
        }
        transform.position = v;
    }
}
