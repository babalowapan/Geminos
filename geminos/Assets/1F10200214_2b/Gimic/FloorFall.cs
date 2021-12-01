using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorFall : MonoBehaviour
{
    bool check = true;
    public int time;
    public float fallY;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "under_c")
        {
            if (check)
            {
                Invoke("fall", time);
                check = false;
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "under_c")
        {
            check = true;
        }
    }

    void fall()
    {
        rb.velocity = new Vector3(0, fallY, 0);
    }
}
