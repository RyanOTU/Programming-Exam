using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    public Camera cam;
    Rigidbody rb;
    bool onXAxis = true;
    public bool gameOver = true;
    public float ballSpeed;
    float camFollowTimer = 50;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam.transform.parent = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
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
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            camFollowTimer = 50;
        }
        if (collision.gameObject.tag == "DeathBox")
        {
            gameOver = true;
            SceneManager.LoadScene(0);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            camFollowTimer--;
            Debug.Log("Exiting");
            rb.useGravity = true;
            rb.angularDrag = 0.8f;
            if (camFollowTimer <= 0) cam.transform.parent = null;
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
