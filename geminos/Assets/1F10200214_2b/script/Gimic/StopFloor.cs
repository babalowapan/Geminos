using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopFloor : MonoBehaviour
{
    private string groundTag = "stop";
    private bool isStop = false;
    private bool isStopEnter, isStopStay, isStopExit;


    // Start is called before the first frame update
    void Start()
    {

    }

    public bool IsFloor()
    {
        if (isStopEnter || isStopStay)
        {
            isStop = true;
        }
        else if (isStopExit)
        {
            isStop = false;
        }

        isStopEnter = false;
        isStopStay = false;
        isStopExit = false;
        return isStop;
    }

    private void OnTriggerEnter2D(Collider2D collision)//空中から接地
    {
        if (collision.tag == groundTag)
        {
            isStopEnter = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)//地面上移動中
    {
        if (collision.tag == groundTag)
        {
            isStopStay = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)//接地から空中
    {
        if (collision.tag == groundTag)
        {
            isStopExit = true;
        }
    }
}
