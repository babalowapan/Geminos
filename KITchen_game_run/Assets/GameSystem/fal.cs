using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(choise_P);
    }

    // ゲーム即リスタート
    void choise_P()
    {
        FadeManager.FadeOut(1);
    }
}
