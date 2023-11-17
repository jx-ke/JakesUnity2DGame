using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level3Score : MonoBehaviour
{
    public static Level3Score instance;

    public Text scoreText;

    public int score = 0;

    public void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = score.ToString() + " collected";
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " collected";
        Debug.Log(score);
    }
}