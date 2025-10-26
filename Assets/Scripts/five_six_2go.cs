using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.InputSystem;

public class five_six_2go : MonoBehaviour
{
    public float minScale = 0.3f;
    public float maxScale = 1.5f;
    public float speedscale = 1;
    public float speedrotation = 5;
    public float alpha;
    public GameObject bigger;
    public GameObject smaller;
    private Vector3 Offset = new Vector3(0, 3, 0);
    private bool small = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bigger.transform.position = transform.position;
        smaller.transform.position = bigger.transform.position + Offset;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 s = smaller.transform.localScale;
        Vector3 ss = bigger.transform.localScale;
        float scale = speedscale * Time.deltaTime;
        float angle = speedrotation * Time.deltaTime;
        alpha += angle;

        if (small)
        {
            s = s * (1 - scale);
            ss = ss * (1 - scale);
            if (s.x <= minScale)
            {
                s.x = minScale;
                small = false;
            }
        }
        else
        {
            s = s * (1 + scale);
            ss = ss * (1 + scale);
            if (s.x >= maxScale)
            {
                s.x = maxScale;
                small = true;
            }
        }

        smaller.transform.rotation = Quaternion.Euler(0, alpha, 0);
        smaller.transform.localScale = s;
        bigger.transform.localScale = ss;
    }
}
