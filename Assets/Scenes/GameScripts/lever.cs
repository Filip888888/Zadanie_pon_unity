using UnityEngine;

public class lever : MonoBehaviour
{

    public float speed = 90f;
    private bool rotate = false;
    private float angle = -45f;
    private Transform bridge;
    private float minY = 6.27f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bridge = GameObject.Find("rope_bridge (1)").transform;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (rotate)
        {

            Vector3 v = bridge.position;
            float vy = speed * Time.deltaTime;
            v.y -= vy;

            angle += speed * Time.deltaTime;
            if (angle >= 45f)
            {
                angle = 45f;
                rotate = false;
            } 
            else
            {
                rotate = true;
            }

            if(v.y <= minY)
            {
                v.y = minY;
            }
            bridge.position = v;
        }

       
        transform.rotation = Quaternion.Euler(0f, 0f, angle);

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")){
            rotate = true;
        }
    }

}
