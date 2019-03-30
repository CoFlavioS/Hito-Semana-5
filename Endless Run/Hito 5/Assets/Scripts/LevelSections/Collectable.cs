using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private Transform target;

    public void setFollowing(Transform following)
    {
        target = following;
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null)
        {
            transform.position = target.position;
        }
        else
        {
            Object.Destroy(gameObject);
        }

    }
}
