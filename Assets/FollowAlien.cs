using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAlien : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset;
    void Start()
    {

    }

    void Update()
    {
        transform.position = target.transform.position + offset;
   
    }
}
