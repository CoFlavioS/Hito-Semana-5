using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    public float health = 1f;
    public bool muerto = false;
    public Text marcador;
    public float puntuacion = 0f;
    [SerializeField] public HealthBar healthBar;

    private void Start()
    {
        InvokeRepeating("HealthReduction", 2f, 1f);
        InvokeRepeating("addPoints", 2f, 1f);
    }

    private void Update()
    {
        healthBar.SetSize(health);
        if (health <= 0)
        {
            CancelInvoke();
            muerto = true;
        }
    }

    private void HealthReduction()
    {
        health -= 0.025f;
    }

    void addPoints()
    {
        puntuacion += 10f;
        marcador.text = Mathf.Round(puntuacion).ToString();
    }
}
