using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMove_R : MonoBehaviour
{
    public GameObject playerObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = playerObj.transform.position;
        transform.position = new Vector3(playerPos.x, -30, 0);
    }
}
