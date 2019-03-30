using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score2 : MonoBehaviour
{
    public Text score;

    void Start()
    {
        score = GetComponent<Text>();
    }

    void Update()
    {
        score.text = "Score: " + ScoreBoard.finalScore[1];
    }
}
