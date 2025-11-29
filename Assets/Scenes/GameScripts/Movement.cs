using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 5f;
    public float thrust = 5f;
    public float jumpforce = 7f;
    private bool isGrounded = true;
    private Rigidbody rb;
    private Transform nose;
    private Vector3 Offset = new Vector3 (0.5f, 0f, 0f);
    Camera_Position cam;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        nose = GameObject.Find("Nose").transform;
        cam = FindObjectOfType<Camera_Position>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cam.move_direction_a)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(Vector3.forward * thrust);
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(Vector3.back * thrust);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(Vector3.left * thrust);
                nose.position = transform.position - Offset;
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(Vector3.right * thrust);
                nose.position = transform.position + Offset;
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                thrust = 10f;
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                thrust = 5f;
            }
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
                isGrounded = false;
            }
        }else if (!cam.move_direction_a)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(Vector3.right * thrust);
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(Vector3.left * thrust);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(Vector3.forward * thrust);
                nose.position = transform.position - Offset;
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(Vector3.back * thrust);
                nose.position = transform.position + Offset;
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                thrust = 10f;
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                thrust = 5f;
            }
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
                isGrounded = false;
            }
        }
    }



    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }


}
