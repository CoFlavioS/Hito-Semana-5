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
    private GameObject[] sectionArray;
    private int sectionCounter = 0;
    public int sunSectionRanFreq = 20;    //Randonmly, 1 in every X will be a sun section
    public int dropletSectionFreq = 5;    //How many sections will be spawn before a drop appears
    public int dropletSectionVar = 2;     //Range of variation in frequency. Calculated after each 
    private int droptletCounter;          //non droplet section spawned.

    public GameObject collectableSun;
    public GameObject collectableDroplet;

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

        //sectionArray = Resources.LoadAll("/", typeof(GameObject)).Cast<GameObject>().ToArray();
        section = Resources.Load("SectionBase", typeof(GameObject)) as GameObject;
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
            //section = SelectSection();
            section = Object.Instantiate(section, spawnPosition, Quaternion.identity, gameObject.transform);
            Debug.Log("miau" + collectableSun.name);
            Debug.Log("miau" + section.name);
            section.GetComponent<Section>().instantiateCollectable(collectableDroplet);

            sectionCounter++;
        }
    }

    GameObject SelectSection()
    {
        return sectionArray[0];
    }

}
