using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class FollowCamera : MonoBehaviour
{
    public GameObject playerObj;
    public Camera cam;


    void Start()
    {
        
    }

    private void Awake()
    {

    }

    void FixedUpdate()
    {
        
    }


    void LateUpdate()
    {
        Vector3 playerPos = playerObj.transform.position;

        if(playerPos.x < 0)
        {
            transform.position = new Vector3(playerPos.x - 5, -8, -10);
        }
        transform.position = new Vector3(playerPos.x+5, -8, -10);
    }


}