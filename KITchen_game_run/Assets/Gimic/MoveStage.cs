using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStage : MonoBehaviour
{
    public GameObject ground;
    float setY;
    private GameObject instance;
    private Rigidbody2D rbody2D = null;
    public Vector3 setPos;

    void CreateMoveStage(float x, float y, float z)
    {
        instance = (GameObject)Instantiate(ground, new Vector3(x, y, z), Quaternion.identity);
        setPos = new Vector3(x, y, z);
    }

    // Start is called before the first frame update
    void Start()
    {
        CreateMoveStage(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
