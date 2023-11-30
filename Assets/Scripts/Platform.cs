using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Platform : MonoBehaviour
{
    Rigidbody rb;
    bool hasCollided = false;
    bool startedDying = false;
    float deathTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (hasCollided && startedDying) deathTimer++;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (deathTimer > 500)
        {
            rb.useGravity = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            hasCollided = true;
        }
    }
}