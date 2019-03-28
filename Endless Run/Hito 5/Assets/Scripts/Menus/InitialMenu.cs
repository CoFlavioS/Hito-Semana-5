using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitialMenu : MonoBehaviour
{
    public GameObject initialMenuUI;
    public bool isPlay = false;

    // Start is called before the first frame update
    void Start()
    {
        isPlay = false;
        initialMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Play()
    {
        initialMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
