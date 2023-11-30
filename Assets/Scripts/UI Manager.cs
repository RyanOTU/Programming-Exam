using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI gemUI;
    int gemTotal = 0;

    void Awake()
    {
        gemUI.text = "Gems: 0";
    }

    public void AddGem(Gem g)
    {
        gemTotal += g.GetValue();
        gemUI.text = "Gems: " + gemTotal;
    }
    public void AddGem(int value)
    {
        gemTotal += value;
        gemUI.text = "Gems: " + gemTotal;
    }
}
