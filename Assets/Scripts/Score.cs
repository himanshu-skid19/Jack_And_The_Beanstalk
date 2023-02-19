using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Score : MonoBehaviour
{
    public Text scoreText;
    //public Text hiScoreText;

    public int scoreCount;
    //public float hiScoreCount;

    public float pointsPerSecond;
    public float timer = 0;
    public bool scoreIncreasing;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer += 0.001f;
        if (timer > 0.3f)
        {
            scoreCount += (int)(pointsPerSecond * timer);
            timer = 0;
            pointsPerSecond += 5;
        }
        else
        {
           
        }
        scoreText.text = "SCORE : " + scoreCount;
        //Debug.Log(Time.deltaTime);
        //hiScoreText.text = "HIGH SCORE : " + hiScoreCount;
    }
}
