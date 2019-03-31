using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disapear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("LowerPlatform", 3f, 0.5f);
    }

    // Update is called once per frame
    private void LowerPlatform()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - 0.25f, transform.position.z); 
    }
}
