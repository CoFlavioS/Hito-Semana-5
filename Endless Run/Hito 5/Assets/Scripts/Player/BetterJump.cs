using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJump : MonoBehaviour
{

    public float fall = 1.25f;
    public float lowJump = 1.25f;

    Rigidbody2D rb2d;

    // Use this for initialization
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb2d.velocity.y < 0)
        {
            rb2d.gravityScale = fall;
        }
        else if (rb2d.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb2d.gravityScale = lowJump;
        }
        else
        {
            rb2d.gravityScale = 1f;
        }
    }
}
