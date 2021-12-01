using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
[RequireComponent(typeof(GameoverCheck))]
[RequireComponent(typeof(GameoverCheck_R))]

public class PlayerMove_R : MonoBehaviour
{
    //インスペクターで設定する
    public float speed;
    public StageCheck_R ground; //new
    public float gravity;
    //float flap = 1000f;
    public float PlayerX = 0;
    //private float jumpPos = 0.0f;
    //float jumpHeight;
    float Jumppower = 95;
    private Animator anim;
    private bool isGround = false;
    private Rigidbody2D rbody2D = null;
    private float move;
    public static float r_time;
    private float Y = -50;
    public GameObject other;
    Vector3 pos;
    Vector3 pos_other;
    private bool swap = true;
    public static float r_last_pos;
    Vector3 ago_pos;
    bool jump = false;

    // Start is called before the first frame update
    void Start()
    {
        pos = this.gameObject.transform.position;
        rbody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim.SetBool("run", false);
        pos_other = other.transform.position;
        r_last_pos = 0;
        r_time = 0;
    }


    // Update is called once per frame
    void Update()
    {
        pos = this.gameObject.transform.position;
        r_last_pos = Mathf.Abs(this.gameObject.transform.position.x);
        if (pos.y <= Y||pos_other.y <= Y)
        {
            anim.SetTrigger("down");
            Debug.Log(this.gameObject.transform.position.x);
            r_last_pos = Mathf.Abs(this.gameObject.transform.position.x);
            FadeManager.FadeOut(2);
            this.gameObject.SetActive(false);
            Time.timeScale = 0;
        }

        else if (PlayerMove.l_time >= 3 || r_time >= 3)
        {
            r_last_pos = Mathf.Abs(this.gameObject.transform.position.x);
            anim.SetTrigger("down");
            FadeManager.FadeOut(2);
        }

        else if(Time.timeScale == 1)
        {

            if (ground.IsGround())//地面に接地しているとき
            {
                rbody2D.velocity = new Vector3(-9, rbody2D.velocity.y, 0);
                isGround = true;
                if (swap) {
                    if (Input.GetKeyDown(KeyCode.D) || R_button.r_p)//ジャンプのキー入力
                    {
                        //jump = true;
                        //rbody2D.velocity = new Vector3(rbody2D.velocity.x, 0, 0);
                        rbody2D.AddForce(new Vector2(Jumppower/3, Jumppower), ForceMode2D.Impulse);
                        R_button.r_p = false;
                        //anim.SetBool("run", false);
                    }
                    else
                    {
                        anim.SetBool("run", true);
                    }
                }
                else
                {
                    if (Input.GetKeyDown(KeyCode.A) || L_button.l_p)//ジャンプのキー入力
                    {
                        //jump = true;
                        //rbody2D.velocity = new Vector3(rbody2D.velocity.x, 0, 0);
                        rbody2D.AddForce(Vector3.up * Jumppower, ForceMode2D.Impulse);
                        L_button.l_p = false;
                        //anim.SetBool("run", false);
                    }
                    else
                    {
                        anim.SetBool("run", true);
                    }

                }
                if (pos.x == ago_pos.x)
                {
                    r_time += Time.deltaTime;
                }
                else
                {
                    r_time = 0;
                }
                ago_pos = this.gameObject.transform.position;
            }

            /*
            else if (ground.IsGround() == false)
            {
                if (jump)
                {
                    anim.SetTrigger("jumpUp");
                    jump = false;
                    anim.SetBool("run", false);
                }
                else if (rbody2D.velocity.y < 0)
                {
                    anim.SetBool("fall", true);
                    anim.SetBool("run", false);
                }
            }
            */


        }
    }

    public void SwapKey()
    {
        if (swap)
        {
            swap = false;
        }
        else
        {
            swap = true;
        }
    }

}
