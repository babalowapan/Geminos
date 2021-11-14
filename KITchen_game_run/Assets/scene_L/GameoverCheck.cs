using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameoverCheck : MonoBehaviour
{

    // Start is called before the first frame update
    private string groundTag = "over";
    private bool isGround = false;
    private bool isGroundEnter, isGroundStay, isGroundExit;


    // Start is called before the first frame update
    void Start()
    {

    }

    public bool GameOver()
    {
        if (isGroundEnter || isGroundStay)
        {
            Debug.Log(GameOver());
            isGround = true;
        }
        else if (isGroundExit)
        {
            isGround = false;
        }

        isGroundEnter = false;
        isGroundStay = false;
        isGroundExit = false;
        return isGround;
    }

    private void OnTriggerEnter2D(Collider2D collision)//空中から接地
    {
        if (collision.tag == groundTag)
        {
            isGroundEnter = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)//地面上移動中
    {
        if (collision.tag == groundTag)
        {
            isGroundStay = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)//接地から空中
    {
        if (collision.tag == groundTag)
        {
            isGroundExit = true;
        }
    }
}
