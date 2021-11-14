using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float PosY;
    float time;
    private Rigidbody2D rb;
    bool check = true;
    public float moveX;
    public float moveY;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(moveX, moveY, 0);
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time >= timer)
        {
            if (check)
            {
                rb.velocity = new Vector3(moveX*-1, moveY*-1, 0);
                check = false;
                time = 0;
            }
            else
            {
                rb.velocity = new Vector3(moveX, moveY, 0);
                check = true;
                time = 0;
            }
            
        }
        //transform.position = new Vector3(transform.position.x, PosY + Mathf.PingPong(Time.time * 2f, 3), transform.position.z);
    }
}
