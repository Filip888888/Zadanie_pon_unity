using UnityEngine;

public class Camera_Position : MonoBehaviour
{
    private GameObject player;
    private GameObject Above;
    private GameObject start;
    private bool selected = false;
    public Vector3 Offset_left = new Vector3 (2f, 3f, -7f);
    public Vector3 Offset_above = new Vector3 (0f, 7f, 0f);
    public bool move_direction_a = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Above = GameObject.Find("Main Camera");
        start = GameObject.Find("FirstPerson");
        player = GameObject.Find("Player");
        Above.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Camera();
        Above.transform.position = player.transform.position + Offset_above;
        start.transform.position = player.transform.position + Offset_left;
    }

    void Camera()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (!selected)
            {
                start.SetActive(false);
                Above.SetActive(true);
                selected = true;
                move_direction_a = true;
            }
            else
            {
                Above.SetActive(false);
                start.SetActive(true);
                selected = false;
                move_direction_a = false;
            }
        }
    }


}
