using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class five_four : MonoBehaviour
{
    public GameObject Cube1;
    public GameObject Cube2;

    public float speed = 5;
    public float maxX = 3;
    public float minX = -3;
    public float maxY = 3;
    public float minY = -3;

    private  bool left = true;
    private bool up = true;

    void Start()
    {
        Cube2.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
    
    void Update()
    {

        Vector3 v1 = Cube1.transform.position;
        Vector3 v2 = Cube2.transform.position;

        float s = speed * Time.deltaTime;

        if (left)
        {
            v1.x = v1.x - s;
            v2.x = v2.x - s;
            if (v1.x <= minX)
            {
                v1.x = minX;
                v2.x = minX;
                left = false;
            }
        }
        else
        {
            v1.x = v1.x + s;
            v2.x = v2.x + s;
            if(v1.x >= maxX)
            {
                v1.x = maxX;
                v2.x = maxX;
                left = true;
            }
        }

        if (up)
        {
            v2.y = v2.y + s;
            if(v2.y >= maxY)
            {
                v2.y = maxY;
                up = false;
            }
        }
        else
        {
            v2.y = v2.y - s;
            if (v2.y <= minY)
            {
                v2.y = minY;
                up = true;
            }
        }

        Cube1.transform.position = v1;
        Cube2.transform.position = v2;
    }
}
