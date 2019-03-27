using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSectionController : MonoBehaviour
{

    public Camera currCamera;
    public GameObject section;
    private Vector2 spawnPosition;

    public static float levelSpeed = 2.5f;
    public float sectionSeparation = 4f;

    private float waitTime;
    private float timer;

    void Start()
    {
        timer = 0f;
        waitTime = sectionSeparation / levelSpeed;

    }

    void Update()
    {
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
            spawnPosition.y = currCamera.orthographicSize;
            spawnPosition.x = position.y * currCamera.aspect;
            Object.Instantiate(section, spawnPosition, Quaternion.identity);
        }
    }
}
