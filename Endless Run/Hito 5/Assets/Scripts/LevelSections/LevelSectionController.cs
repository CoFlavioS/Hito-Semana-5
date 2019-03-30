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
    public float sunSectionChance = 10f;//p chance section has a sun
    public int dropletSectionWait = 5;    //How many sections will be spawn before a drop appears
    public int dropletSectionVar = 1;     //Range of variation in wait. Calculated after each 
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

        droptletCounter = dropletSectionWait + Random.Range(-dropletSectionVar, dropletSectionVar);

        /**
         *  Descomentar esto cuando solo haya secciones validas en la carpeta Resources
         */
        //sectionArray = Resources.LoadAll("/", typeof(GameObject)).Cast<GameObject>().ToArray();
        /**
         */

        /**
         *  Comentar esto para hacer pruebas con los prefabs en resources
         */
        section = Resources.Load("SectionBase", typeof(GameObject)) as GameObject;
        /**
         */      
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

            /**
             *  Descomentar esto cuando solo haya secciones validas en la carpeta Resources
             */
            //section = SelectSection();
            /**
             * 
             */

            section = Object.Instantiate(section, spawnPosition, Quaternion.identity, gameObject.transform);

            GenerateCollectable();


            sectionCounter++;
        }
    }

    private GameObject SelectSection()
    {
        return sectionArray[Random.Range(0, sectionArray.Length)];
    }

    private void GenerateCollectable()
    {
        Debug.Log("Section Counter: " + sectionCounter + " Droptlet Counter: " + droptletCounter);
        if(sectionCounter >= droptletCounter)
        {
            Debug.Log("Generando gota");
            section.GetComponent<Section>().instantiateCollectable(collectableDroplet);

            sectionCounter = 0;
            droptletCounter = dropletSectionWait + Random.Range(-dropletSectionVar, dropletSectionVar);

        } else if(Random.value <= sunSectionChance)
        {
            section.GetComponent<Section>().instantiateCollectable(collectableSun);
        }
    }
}
