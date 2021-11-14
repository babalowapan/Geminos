using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndFloor : MonoBehaviour
{
    GameObject sil;
    GameObject gol;
    Vector3 pos_l;
    Vector3 pos_r;
    // Start is called before the first frame update
    void Start()
    {
        sil = GameObject.Find("silver");
        gol = GameObject.Find("gold");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "under_c")
        {
            PlayerMove.l_last_pos = sil.transform.position.x;
            PlayerMove_R.r_last_pos = Mathf.Abs(gol.transform.position.x);
            FadeManager.FadeOut(2);
        }
    }
}
