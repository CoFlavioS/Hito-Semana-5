using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialMenu : MonoBehaviour
{
    public  GameObject initialMenuUI;
    public bool isPlay = false;

    // Start is called before the first frame update
    void Start()
    {
        isPlay = false;
        initialMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }
    
    public void Play()
    {
        Time.timeScale = 1f;
        initialMenuUI.SetActive(false);
        isPlay = true;
    }

    public void Quit()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
