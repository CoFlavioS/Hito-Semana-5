using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialMenu : MonoBehaviour
{
    public  GameObject initialMenuUI;
    public bool isPlay = false;
    public static bool initialMenuActive;

    // Start is called before the first frame update
    void Start()
    {
        isPlay = false;
        initialMenuUI.SetActive(true);
        Time.timeScale = 0f;
        initialMenuActive = true;
    }
    void Update()
    {
        if (initialMenuActive)
        {
            initialMenuUI.SetActive(true);
        }
        else
        {
            initialMenuUI.SetActive(false);
        }
    }
    public void Play()
    {
        Time.timeScale = 1f;
        initialMenuActive = false;
        isPlay = true;
    }

    public void Quit()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }

    public void OpenScoreBoard()
    {
        initialMenuActive = false;
        ScoreBoard.scoreBoardActive = true;
    }
}
