using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Camera cam;
    Rigidbody rb;
    bool onXAxis = true;
    bool gameOver = false;
    public float ballSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam.transform.parent = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            onXAxis = !onXAxis;
        }
        if (onXAxis)
        {
            rb.velocity = new Vector3(ballSpeed, rb.velocity.y, 0);
        }
        else
        {
            rb.velocity = new Vector3(0, rb.velocity.y, ballSpeed);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.GetComponent<Platform>())
        {
            Debug.Log("Exiting");
            rb.useGravity = true;
            rb.angularDrag = 0.8f;
            cam.transform.parent = null;
            gameOver = true;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            rb.useGravity = false;
        }
    }
}
