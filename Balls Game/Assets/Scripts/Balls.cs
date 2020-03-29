using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    public RotateBalls controlator;
    public int scoreCounter = 0;
    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Score") 
        {
            controlator.ScoreAtt();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Platform")
        {

            controlator.GameOver();
        }
    }
}