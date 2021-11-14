using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCreator_R : MonoBehaviour
{
    public GameObject ground;
    public GameObject switch_move;
    public GameObject Switch;
    public GameObject move_ground;
    public GameObject endFloor;
    public GameObject fallFloor;
    Rez_wall switchmove;
    Switch sw;
    MoveStage movestage;
    Move move;
    FloorFall fall;
    float setY;

    void CreateStage(float x, float y, float z)
    {
        GameObject instance = (GameObject)Instantiate(ground, new Vector3(x, y, z), Quaternion.identity);
    }

    void CreateSwitchMove(float x, float y, float z,int i, float n, float t)
    {
        GameObject instance = (GameObject)Instantiate(switch_move, new Vector3(x, y, z), Quaternion.identity);
        switchmove.num = i;
        switchmove.moveX = n;
        switchmove.moveY = t;
    }

    void CreateSwitch(float x, float y, float z, int i)
    {
        GameObject instance = (GameObject)Instantiate(Switch, new Vector3(x, y, z), Quaternion.identity);
        sw.Move_select = i;
        Debug.Log(sw.move_select);
    }

    void CreateMoveStage(float x, float y, float z, float i, float n,float t)
    {
        GameObject instance = (GameObject)Instantiate(move_ground, new Vector3(x, y, z), Quaternion.identity);
        movestage.setPos = new Vector3(x, y, z);
        move.moveX = i;
        move.moveY = n;
        move.timer = t;
    }

    void CreateEndFloor(float x, float y, float z)
    {
        GameObject instance = (GameObject)Instantiate(endFloor, new Vector3(x, y, z), Quaternion.identity);
        
    }

    void CreateFallFloor(float x, float y, float z, int i, float n)
    {
        GameObject instance = (GameObject)Instantiate(fallFloor, new Vector3(x, y, z), Quaternion.identity);
        fall.time = i;
        fall.fallY = n;
    }


    // Start is called before the first frame update5 -16.5 0
    void Start()
    {
        switchmove = switch_move.GetComponent<Rez_wall>();
        sw = Switch.GetComponent<Switch>();
        movestage = move_ground.GetComponent<MoveStage>();
        move = move_ground.GetComponent<Move>();
        fall = fallFloor.GetComponent<FloorFall>();
        setY = -10f;
        CreateStage(-25.0f, setY, 0.0f);
        CreateStage(-75.0f, setY, 0.0f);
        CreateStage(-50.0f, setY, 0.0f);
        CreateStage(-100.0f, setY, 0.0f);
        //CreateSwitch(-60.0f, setY, 0.0f, 5);
        CreateSwitchMove(-70.0f, setY, 0.0f, 5, 0, 5);
        CreateSwitchMove(-80.0f, setY, 0.0f, 1, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}