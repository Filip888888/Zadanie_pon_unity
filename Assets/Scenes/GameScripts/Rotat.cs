using UnityEngine;

public class Rotat : MonoBehaviour
{

    public float speed = 65f;
    private float alpha = 0f;
    public float direction = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        alpha -= speed * Time.deltaTime;

        transform.rotation = Quaternion.Euler(0f, 0f, alpha * direction);


    }
}
