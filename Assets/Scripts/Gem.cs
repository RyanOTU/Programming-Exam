using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gem : MonoBehaviour
{
    public int gemValue = 1;
    UIManager uiManager;
    private void Start()
    {
        uiManager = GameObject.Find("UI Manager").GetComponent<UIManager>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Gem hit!");
        if (collision.gameObject.tag == "Ball")
        {
            Debug.Log("Gem collected!");
            uiManager.AddGem(this);
            destroyGem();
        }
    }
    public int GetValue()
    {
        return gemValue;
    }
    public void destroyGem()
    {
        GameObject.Destroy(gameObject);
    }
}
