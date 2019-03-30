using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadMenu : MonoBehaviour
{
    public GameObject deadMenuUI;
    public bool dead;
    public bool scoreUpdate;

    // Start is called before the first frame update
    void Start()
    {
        deadMenuUI.SetActive(false);
        dead = false;
        scoreUpdate = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (dead && !scoreUpdate)
        {
            ScoreBoard.organize();
            deadMenuUI.SetActive(true);
            Time.timeScale = 0f;
            scoreUpdate = true;
        }
    }


    public void Restart()
    {
        deadMenuUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Debug.Log("Quitting game...");
        Application.Quit();//cambiar por LoadScene cuando exista menu de inicio, igual en menu pausa
    }
}
