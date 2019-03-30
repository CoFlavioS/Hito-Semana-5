using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialMenu : MonoBehaviour
{
    public  GameObject initialMenuUI;
    public GameObject inGameUI;
    public bool isPlay = false;

    // Start is called before the first frame update
    void Start()
    {
        isPlay = false;
        initialMenuUI.SetActive(true);
        inGameUI.SetActive(false);
        Time.timeScale = 0f;
    }
    
    public void Play()
    {
        Time.timeScale = 1f;
        initialMenuUI.SetActive(false);
        inGameUI.SetActive(true);
        isPlay = true;
    }

    public void Quit()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
