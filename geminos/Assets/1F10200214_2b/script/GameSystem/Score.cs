using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;

public class Score : MonoBehaviour
{
	// Start is called before the first frame update
	//　前のUpdateの時の秒数
	//　タイマー表示用テキスト
	float l_pos;
	float r_pos;
	float time;
	string T_time;
	float score;
	int sco;
	private Text ScoreText;

	[DllImport("__Internal")]
	private static extern void SendData(int x, string str);

	void Start()
	{
		FadeManager.FadeIn();
		Debug.Log(PlayerMove.l_last_pos);
		Debug.Log(PlayerMove_R.r_last_pos);
		ScoreText = GetComponent<Text>();
		score = PlayerMove.l_last_pos;
		
		if (score >= PlayerMove_R.r_last_pos)
        {
			score = PlayerMove_R.r_last_pos;
			Debug.Log(score);
		}
		sco = (int)score;
		SendData(sco, "b90b99255adf");
		T_time = "Score:" + sco.ToString();
		Debug.Log(T_time);
	}

    void Update()
    {
		ScoreText.text = T_time;
	}

}
