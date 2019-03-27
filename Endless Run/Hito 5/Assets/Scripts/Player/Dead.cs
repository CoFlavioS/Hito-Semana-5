using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "deadly")
        {
            Destroy(gameObject);
        }
    }
}
