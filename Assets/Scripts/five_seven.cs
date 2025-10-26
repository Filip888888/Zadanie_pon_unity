using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.InputSystem;

public class five_seven : MonoBehaviour
{

    private float alpha;
    public float maxZ = 3;
    public float minZ = -3;
    public float speed = 0.1f;
    private bool forward = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = transform.position;
        float sz = speed * Time.deltaTime;
        float angle = speed * Time.deltaTime;
        alpha += angle;
        if (forward)
        {
            v.z += sz;
            if (v.z >= maxZ)
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
        transform.rotation = Quaternion.Euler(0, angle, 0);
        transform.position = v;
    }
}
