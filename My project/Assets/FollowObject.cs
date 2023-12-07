using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public GameObject objectToFollow;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // Position the camera in front of the object.
        transform.position = objectToFollow.transform.position + objectToFollow.transform.forward * offset.z + objectToFollow.transform.up * offset.y;

        // Make the camera look at the object.
        transform.LookAt(objectToFollow.transform.position);
    }
}         