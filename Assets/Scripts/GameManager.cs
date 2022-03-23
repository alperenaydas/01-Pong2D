using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int playerScore;

    private int aiScore;

    public TMP_Text playerScoreText;
    public TMP_Text aiScoreText;

    public Transform ball;
    private Rigidbody2D ballRb;
    
    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
        aiScore = 0;
        ballRb = ball.GetComponent<Rigidbody2D>();
    }

    public void SetScore(bool isPlayer)
    {
        if (isPlayer)
        {
            playerScore++;
            playerScoreText.text = playerScore.ToString();
        }
        else
        {
            aiScore++;
            aiScoreText.text = aiScore.ToString();
        }

        ball.position = Vector2.zero;
        ballRb.velocity = Vector2.zero;

        Invoke("RestartBall", 0.5f);
    }

    void RestartBall()
    {
        ballRb.velocity = new Vector2(-1, Random.Range(-1f, 1f))*ball.GetComponent<Ball>().speed;
    }
}
