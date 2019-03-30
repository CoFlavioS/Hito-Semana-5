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

    private Transform collectablePos;

    void Start()
   {
        controller = GameObject.FindWithTag("GameController");
        controlScript = controller.GetComponent<LevelSectionController>();
        leftBorder = -controlScript.borderDistance;
    }

    public void instantiateCollectable(GameObject collectable)
    {

        collectablePos = transform.Find("sun or water");
        Debug.Log(collectable);
        Debug.Log(collectablePos);
        Object.Instantiate(collectable, collectablePos.transform);
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
