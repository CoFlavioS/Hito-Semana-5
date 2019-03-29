using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LevelSectionController : MonoBehaviour
{

    public Camera currCamera;

    [HideInInspector]
    public float borderDistance;   //Distance between controller and controller
    [HideInInspector]
    public float bufferDistance;   //Buffer distamce so sections dont pop-in or out
    private Vector2 spawnPosition;

    private GameObject section;
    private GameObject[] commonSections;
    private GameObject[] dropletSections;
    private GameObject[] sunSections;
    private int sectionCounter = 0;
    public int sunSectionRanFreq = 20;    //Randonmly, 1 in every X will be a sun section
    public int dropletSectionFreq = 5;    //How many sections will be spawn before a drop appears
    public int dropletSectionVar = 2;     //Range of variation in frequency. Calculated after each 
    private int droptletCounter;          //non droplet section spawned.


    public float levelSpeed = 1f;
    private float waitTime;
    private float timer;

    void Start()
    {
        waitTime = Section.sectionWidth / levelSpeed;
        timer = waitTime;
        bufferDistance = Section.sectionWidth;
        borderDistance = currCamera.orthographicSize * currCamera.aspect + bufferDistance;
        spawnPosition.x = borderDistance;
        spawnPosition.y = 0f;

        droptletCounter = dropletSectionFreq + Random.Range(0, dropletSectionVar);

        commonSections = Resources.LoadAll("CommonSections", typeof(GameObject)).Cast<GameObject>().ToArray();
        dropletSections = Resources.LoadAll("DropletSections", typeof(GameObject)).Cast<GameObject>().ToArray();
        sunSections = Resources.LoadAll("SunSections", typeof(GameObject)).Cast<GameObject>().ToArray();
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
            section = SelectSection();
            Object.Instantiate(section, spawnPosition, Quaternion.identity, gameObject.transform);
            sectionCounter++;
        }
    }

    GameObject SelectSection()
    {
        
        return commonSections[Random.Range(0, commonSections.Length)];
    }
}
