using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Marcador : MonoBehaviour
{
    public Text score;
    public int points;
    private DeadMenu dMenu;
    private PauseMenu pMenu;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        RefreshScore();
    }

    public void RefreshScore()
    {
        score.text = "Score: " + points;
    }
}
