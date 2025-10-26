using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class five_five : MonoBehaviour
{
    public float speed = 50f;
    private Vector3 position;
    public float alpha;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(2f, 4f, 2f);
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float angle = speed * Time.deltaTime;
        alpha += angle;

        transform.rotation = Quaternion.Euler(0f, alpha, 0f);
        
    }
}
