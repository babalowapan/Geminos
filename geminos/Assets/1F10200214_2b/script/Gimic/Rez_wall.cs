using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rez_wall : MonoBehaviour
{
    public int num;
    private Switch Switch;
    private int check;
    private Vector3 pos;
    public float moveX;
    public float moveY;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(num);
        pos = this.gameObject.transform.position;
        this.Switch = FindObjectOfType<Switch>();
    }

    public void Rez()
    {
        
            if (Switch.select_i == num)
            {
                Move();
            }
        
    }

    // Update is called once per frame
    public void Move()
    {
        Debug.Log("iiiiii");
        this.gameObject.transform.Translate(moveX,moveY,Time.deltaTime);

    }
}
