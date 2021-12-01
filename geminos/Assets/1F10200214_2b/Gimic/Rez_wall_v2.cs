using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rez_wall_v2 : MonoBehaviour
{
    private Switch Switch;
    public int num;
    private int check;
    private Vector3 pos;
    private Vector3 target;
    public float moveX;
    public float moveY;
    public float sp = 1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(num);
        this.Switch = FindObjectOfType<Switch>();
        pos = this.gameObject.transform.position;
        target = new Vector3(pos.x+moveX, pos.y+moveY,1);
    }

    // Update is called once per frame
    public void Rez_2()
    {
        this.Switch = FindObjectOfType<Switch>();
        Debug.Log(Switch.select_i);
            if (Switch.select_i == num)
            {
                Debug.Log("ta");
                Move();
            }
    }

    void Move()
    {
        Debug.Log("ta");
        this.transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * sp);
        Debug.Log(this.transform.position);
    }
}
