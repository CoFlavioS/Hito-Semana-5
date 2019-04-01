using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMov : MonoBehaviour
{
    float scrollSpeed = 5f;
    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }
    
    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * scrollSpeed, 35.5f);
        transform.position = startPos + Vector3.left * newPos;
    }
}
