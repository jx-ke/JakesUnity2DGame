using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {

	public static int score;

	public static int highscore;

	public Text text;

	void Start()
	{
		text = GetComponent<Text> ();

		score = 0;

		highscore = PlayerPrefs.GetInt ("highscore", highscore);
	}

	void Update()
	{
		if (score > highscore);
		highscore = score;
		text.text = "" + score;

		PlayerPrefs.SetInt ("highscore", highscore);
	}

	public static void AddPoints (int pointsToAdd)
	{
		score += pointsToAdd;
	}

	public static void Reset()
	{
		score = 0;
	}
}
