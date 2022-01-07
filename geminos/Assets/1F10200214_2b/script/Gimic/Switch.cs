using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
	// Start is called before the first frame update
	Rigidbody2D rb;
	BoxCollider2D col;
	private bool check = true;
	private string groundTag = "under_c";
	GameObject s_L;
	GameObject s_R;
	GameObject s_Lk;
	GameObject s_Rk;
	GameObject swap;
	Rez_wall_v2 Rez_Wall_v2;
	Rez_wall Rez_Wall;
	SwapUI swapUI;
	public int move_select;	//スイッチと連動させる壁を指定したい
	public int Move_select
    {
        set { select_i = value; }
        get { return select_i; }
    }
	public static int select_i;
	private bool IsPush = false;
	public bool ispush
    {
		get { return IsPush; }
		set { IsPush = value; }
    }

	// Use this for initialization
	void Start()
	{
		rb = this.gameObject.GetComponent<Rigidbody2D>();
		col = this.gameObject.GetComponent<BoxCollider2D>();
		s_L = GameObject.Find("CameraSwap");
		s_R = GameObject.Find("CameraSwap_R");
		s_Lk = GameObject.Find("silver");
		s_Rk = GameObject.Find("gold");
		swap = GameObject.Find("SwapUI");
		Rez_Wall_v2 = FindObjectOfType<Rez_wall_v2>();
		Rez_Wall = FindObjectOfType<Rez_wall>();
		swapUI = swap.GetComponent<SwapUI>();
	}

	// Update is called once per frame
	void Update()
	{

	}
	void OnTriggerEnter2D(Collider2D collision)
	{
		select_i = move_select;
		Debug.Log(Move_select);
		Rez_Wall_v2 = FindObjectOfType<Rez_wall_v2>();
		Rez_Wall = FindObjectOfType<Rez_wall>();
		Debug.Log("test");
		if (check)
		{
			if (collision.tag == "under_c")
			{
				Debug.Log("rrrrrr");
				if (move_select == 2)
				{
					Debug.Log("taaaa");
					s_L.GetComponent<CameraSwap>().swap_L();
					s_R.GetComponent<CameraSwap_R>().swap_R();
					check = false;
				}
				else if (move_select == 3)
				{
					Debug.Log("tiiiii");
					s_Lk.GetComponent<PlayerMove>().SwapKey();
					s_Rk.GetComponent<PlayerMove_R>().SwapKey();
					
					check = false;

				}
                else
                {
					Debug.Log("tuuuuuu");
					if (Rez_Wall_v2 != null)
                    {
						Debug.Log(Move_select);
						Rez_Wall_v2.Rez_2();
					}
					if(Rez_Wall != null)
                    {
						Rez_Wall.Rez();
					}
                }

				
			}
			IsPush = true;
		}
        else
        {
			IsPush = false;
		}
	}

	void OnTriggerStay2D(Collider2D collision)
	{
		Rez_Wall_v2 = FindObjectOfType<Rez_wall_v2>();
		Rez_Wall = FindObjectOfType<Rez_wall>();

		if (check)
		{
			if (collision.tag == "under_c")
			{

				if (Rez_Wall_v2 != null)
				{
					Rez_Wall_v2.Rez_2();
				}
				if (Rez_Wall != null)
				{
					Rez_Wall.Rez();
				}


			}
		}
		else
		{
			check = false;
			IsPush = false;
		}
	}


	void OnTriggerExit2D(Collider2D collision)
    {
		select_i = 0;
		if (collision.tag == groundTag)
		{
			check = true;
			IsPush = false;
		}
    }
}
