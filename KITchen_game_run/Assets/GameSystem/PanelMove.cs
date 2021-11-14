using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelMove : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    private int page = 0;
    // Start is called before the first frame update
    void Start()
    {
        p1.SetActive(true);
        p2.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (page == 0)
            {
                p1.SetActive(false);
                p2.SetActive(true);
                page++;
            }
        }
    }
}
