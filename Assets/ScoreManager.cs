using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text Text;

    public int Score = 0;

    public void AddScore(int score = 10)
    {
        Score += score;
        Debug.Log(Score);

        if (Text != null)
        {
            Text.text = "Score : " + Score.ToString();
        }
    }


}
