using UnityEngine;

public class Movement : MonoBehaviour
{
    public float thrust = 2f;
    public float jumpforce = 7f;
    private bool isGrounded = true;
    private Rigidbody rb;
    private Transform nose;
    private Vector3 Offset = new Vector3 (0.5f, 0f, 0f);
    private bool isonladder = false;
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
        if (cam.move_direction_a && !isonladder)
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
        }
        else if (!cam.move_direction_a && !isonladder)
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
        else if (isonladder)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(Vector3.up * thrust);
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(Vector3.down * thrust);
            }
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("ladder"))
        {
            isonladder = true;
        }

        if (collision.gameObject.CompareTag("onmoving"))
        {
            transform.SetParent(collision.transform);
            isGrounded = true;
        }

    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }

        if (collision.gameObject.CompareTag("ladder"))
        {
            isonladder = false;
        }

        if (collision.gameObject.CompareTag("onmoving"))
        {
            transform.SetParent(null);
            isGrounded = false;
        }

    }

}
