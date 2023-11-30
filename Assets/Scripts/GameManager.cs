using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public BallController ball;
    public Button startButton;
    public TextMeshProUGUI previousScore;
    public void StartGame()
    {
        ball.gameOver = false;
    }
    public void HideStart()
    {
        startButton.gameObject.SetActive(false);
        previousScore.gameObject.SetActive(false);
    }
}
