using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSectionController : MonoBehaviour
{

    public Camera currCamera;
    public GameObject section;
    [HideInInspector]
    public float borderDistance;   //Distance between controller and controller
    public float bufferDistance;   //Buffer distamce so sections dont pop-in or out
    private Vector2 spawnPosition;

    public float levelSpeed = .1f;
    private float waitTime;
    private float timer = 0f;

    void Start()
    {
        waitTime = Section.sectionWidth / levelSpeed;
        bufferDistance = Section.sectionWidth*20;
        borderDistance = currCamera.orthographicSize * currCamera.aspect + bufferDistance;
        spawnPosition.x = borderDistance;
        spawnPosition.y = 0f;
    }

    void FixedUpdate()
    {
        waitTime = Section.sectionWidth / levelSpeed;

        timer += Time.deltaTime;

        if(timer > waitTime)
        {
            timer -= waitTime;
            CreateSection();
        }

    }

    void CreateSection()
    {
        if (currCamera.enabled && currCamera.orthographic)
        {
            Object.Instantiate(section, spawnPosition, Quaternion.identity);
        }
    }
}
