using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public static int score;
    int highscore;
    public TMP_Text ScoreText;
    public TMP_Text HighscoreText;
    void Start()
    {
        score = 0;
        HighscoreText.text = PlayerPrefs.GetInt("highscore", 0).ToString();
        //PlayerPrefs.DeleteKey("highscore");
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = score.ToString();
        if(score > PlayerPrefs.GetInt("highscore",0))
        {
            highscore = score;
            PlayerPrefs.SetInt("highscore", highscore);
            HighscoreText.text = PlayerPrefs.GetInt("highscore", 0).ToString();
        }
    }
}
