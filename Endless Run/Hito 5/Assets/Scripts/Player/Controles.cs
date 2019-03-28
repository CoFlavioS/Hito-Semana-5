using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour
{
    public bool grounded = false;
    public float jumPower = 10f;
    private Rigidbody2D rb2d;
    private bool jump;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && grounded)
        {
            jump = true;
        }

    }

    void FixedUpdate()
    {        
        if (jump)
        {
            rb2d.AddForce(Vector2.up * jumPower, ForceMode2D.Impulse);
            jump = false;
        }

    }
}
