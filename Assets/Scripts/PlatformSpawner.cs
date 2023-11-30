using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public Transform firstPlatform;
    bool hasGenerated = false;
    public int spawnAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasGenerated)
        {
            for (int i = 0; i < spawnAmount; i++)
            {

            }
        }
    }
}
