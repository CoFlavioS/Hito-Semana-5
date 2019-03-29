using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    public static float health;
    public static bool muerto = false;
    public Text marcador;
    public static float puntuacion;
    [SerializeField] public HealthBar healthBar;

    private void Start()
    {
        muerto = false;
        health = 1f;
        puntuacion = 0f;
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
    }
}
