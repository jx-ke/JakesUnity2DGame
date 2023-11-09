using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager1 : MonoBehaviour
{
    public static ScoreManager1 instance;

    public Text scoreText;

    public int score = 0;

    public void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = score.ToString() + "/5 collected";
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + "/5 collected";
        Debug.Log(score);
    }
}