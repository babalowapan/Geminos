using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isGameOver = false;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {

        //★ここにゲームオーバー時の処理

        //★追加2
        //プレイヤーを止める


        //ゲームオーバー画面を出す
        FadeManager.FadeOut(2);
    }
}
