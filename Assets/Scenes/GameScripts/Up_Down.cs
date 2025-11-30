using UnityEngine;

public class Up_Down : MonoBehaviour
{

    public float speed = 4f;
    private bool up = true;
    public float maxY = 8f;
    public float minY = 2f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = transform.position;

        float vy = speed * Time.deltaTime;

        if (up)
        {
            v.y += vy;
            if(v.y >= maxY) {
                v.y = maxY;
                up = false;
            }
        }
        else
        {
            v.y -= vy;
            if(v.y <= minY)
            {
                v.y = minY;
                up = true;
            }
        }
        transform.position = v;
    }
}
