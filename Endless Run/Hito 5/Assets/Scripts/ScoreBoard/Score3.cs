﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score3 : MonoBehaviour
{
    public Text score;

    void Start()
    {        
        score = GetComponent<Text>();
    }
    void Update()
    {
        score.text = "Score: " + ScoreBoard.score[2];
    }
}
