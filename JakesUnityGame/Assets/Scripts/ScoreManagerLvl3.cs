using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerLvl3 : MonoBehaviour
{
    public static ScoreManagerLvl3 instance;

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