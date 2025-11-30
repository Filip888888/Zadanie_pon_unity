using UnityEngine;

public class Checkpoints : MonoBehaviour
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
        if(player.position.y < 0)
        {
            player.position = new Vector3(2.5f, 2.5f, -2.3f);
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.transform.position = new Vector3(34f, 11.8f, -2.3f);
        }
    }

}
