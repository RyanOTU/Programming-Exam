using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Rigidbody rb;
    bool hasCollided = false;
    bool startedDying = false;
    bool hasGenerated = false;
    float deathTimer = 0;
    public int startingPlatformsAmount = 20;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        for (int i = 0; i < startingPlatformsAmount; i++)
        {
            int xOrZ = Random.Range(0, 1);
            Instantiate(this, this.transform);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!hasGenerated)
        {

        }
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