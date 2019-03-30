using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    [SerializeField] private DeadMenu menu;
    // Use this for initialization
    void Update()
    {
        if (GameHandler.muerto)
        {
            menu.dead = true;
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
            Debug.Log("marmota");
        if (col.gameObject.tag == "deadly")
        {
            menu.dead = true;
        }
    }
}
