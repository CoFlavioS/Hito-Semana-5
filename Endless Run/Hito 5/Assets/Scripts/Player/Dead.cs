using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    [SerializeField] private DeadMenu menu;
    // Use this for initialization
    void Start()
    {
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "deadly")
        {
            Debug.Log("marmota");
            menu.dead = true;
        }
    }
}
