using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Section : MonoBehaviour
{
    public GameObject controller;
    private LevelSectionController controlScript;
    public static float sectionWidth = 45f;
    private float scrollSpeed;
    private float leftBorder;
    void Start()
    {
        controller = GameObject.FindWithTag("GameController");
        controlScript = controller.GetComponent<LevelSectionController>();
        leftBorder = -controlScript.borderDistance;
    }


    void FixedUpdate()
    {
        scrollSpeed = controlScript.levelSpeed * Time.deltaTime;
        transform.position += Vector3.left * scrollSpeed;
        if(transform.position.x < leftBorder)
        {
            Destroy(gameObject);
        }

    }
}
