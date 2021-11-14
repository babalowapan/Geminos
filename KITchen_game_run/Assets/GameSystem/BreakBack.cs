using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BreakBack : MonoBehaviour
{
    GameObject target1;
    GameObject target2;
    Vector3 pos1;
    Vector3 pos2;
    Vector3 obj_pos;

    // Start is called before the first frame update
    void Start()
    {
        target1 = GameObject.Find("silver");
        target2 = GameObject.Find("gold");
        obj_pos = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        pos1 = target1.transform.position;
        pos2 = target2.transform.position;
        if (pos2.x + 200 <= obj_pos.x && obj_pos.x <= pos1.x - 200)
        {
            Destroy(gameObject);
        }

    }
}