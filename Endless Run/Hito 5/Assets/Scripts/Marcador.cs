using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Marcador : MonoBehaviour
{
    public Text score;
    private DeadMenu dMenu;
    private PauseMenu pMenu;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        RefreshScore();
    }

    public void RefreshScore()
    {
        score.text = "Score: " + GameHandler.puntuacion;
    }
}
