using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [SerializeField] private BallController ball;
    [SerializeField] private Transform leftGoal;
    [SerializeField] private Transform rightGoal;
    [SerializeField] private TextMeshProUGUI leftScoreText;
    [SerializeField] private TextMeshProUGUI rightScoreText;
    [SerializeField] private TextMeshProUGUI winnerText;
    [SerializeField] private GameObject WinPanel;
    [SerializeField] private GameObject leftScoreObject;
    [SerializeField] private GameObject rightScoreObject;
    private int leftScore = 0;
    private int rightScore = 0;
    private bool playWinSound;
    private void Awake()
    {
        Time.timeScale = 1;
        ball.ResetBall();
    }
    private void Update()
    {
        Win();

        if (ball.transform.position.x < leftGoal.position.x)
        {
            rightScore++;
            UpdateScore();
            ball.ResetBall();
        }
        else if (ball.transform.position.x > rightGoal.position.x)
        {
            leftScore++;
            UpdateScore();
            ball.ResetBall();
        }
    }

    public void Score(string scorer)
    {
        if (scorer == "Left")
            leftScore++;
        else
            rightScore++;

        UpdateScore();
        ball.ResetBall();
        FindObjectOfType<PlayerController>().ResetPosition();
        FindObjectOfType<AIController>().ResetPosition();
    }

    private void UpdateScore()
    {
        leftScoreText.text = leftScore.ToString();
        rightScoreText.text = rightScore.ToString();
    }

    private void Win()
    {
        if (rightScore >= 5)
        {
            winnerText.text = "Player 2 win!";
            Time.timeScale = 0;
            WinPanel.SetActive(true);
            leftScoreObject.SetActive(false);
            rightScoreObject.SetActive(false);
            if (!playWinSound)
            {
                SoundManager.PlaySound(SoundType.Victory);
                playWinSound = true;
            }
        }
        else if (leftScore >= 5)
        {
            winnerText.text = "Player 1 win!";
            Time.timeScale = 0;
            WinPanel.SetActive(true);
            leftScoreObject.SetActive(false);
            rightScoreObject.SetActive(false);
            if (!playWinSound)
            {
                SoundManager.PlaySound(SoundType.Victory);
                playWinSound = true;
            }
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

} 

