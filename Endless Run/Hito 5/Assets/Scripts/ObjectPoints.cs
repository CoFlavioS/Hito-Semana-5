using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoints : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "sol")
        {
            Destroy(col.gameObject);
            GameHandler.puntuacion += 100f;
        }
        else if (col.gameObject.tag == "agua")
        {
            Destroy(col.gameObject);
            GameHandler.health += 0.25f;
        }
    }
}
