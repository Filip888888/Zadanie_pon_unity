using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class five_four_child : MonoBehaviour
{
    public float speed = 50f;
    public float alpha;
    private Vector3 v;
    private Vector3 Offset = new Vector3(0f, 1f, 0f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.localPosition = new Vector3(0f, 0f, 0f) + Offset;
        v = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        float angle = speed * Time.deltaTime;
        alpha += angle;

        transform.rotation = Quaternion.Euler(0f, alpha, 0f);
    }
}
