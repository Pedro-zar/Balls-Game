using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RotateBalls : MonoBehaviour
{
    public float speed;
    bool right;
    public GameObject gameOver;
    public int score;
    public Text scoreText;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            right = !right;
        }

        if (right)
        {
            transform.Rotate(new Vector3(0f, 0f, speed * Time.deltaTime));
        }
        else
        {
            transform.Rotate(new Vector3(0f, 0f, -speed * Time.deltaTime));
        }
    }

    public void GameOver() 
    {
        gameOver.SetActive(true);
    }

    public void RestartGame() 
    {
        SceneManager.LoadScene(0);
    }

    public void ScoreAtt() 
    {
        score++;
        scoreText.text = score.ToString();

    }
}
