using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public Transform firstPlatform;
    bool hasGenerated = false;
    public int spawnAmount;
    public GameObject platformToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        //This literally crashes unity every single time and I have no clue why
        /*if (!hasGenerated)
        {
            for (int i = 0; i < spawnAmount; i++)
            {
                int xOrZ = Random.Range(0, 1);
                if (xOrZ == 1) Instantiate(this, this.transform.position + new Vector3(0, 0, platformToSpawn.transform.localScale.x), Quaternion.identity);
                if (xOrZ == 0) Instantiate(this, this.transform.position + new Vector3(platformToSpawn.transform.localScale.x, 0, 0), Quaternion.identity);
            }
            hasGenerated = true;
        }*/
    }

    // Update is called once per frame
    void Update()
    {

    }
}
