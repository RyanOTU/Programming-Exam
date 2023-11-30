using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public BallController ball;
    public Button startButton;
    public void StartGame()
    {
        ball.gameOver = false;
    }
    public void HideButton()
    {
        startButton.gameObject.SetActive(false);
    }
}
