using UnityEngine;

public class Spiked_Collision : MonoBehaviour
{

    private Transform player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player").transform;        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.position = new Vector3 (66.8f, 11.5f, -2.35f);
        }
    }

}
