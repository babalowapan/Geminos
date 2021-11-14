using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Retire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(retire);
    }

    // Update is called once per frame
    void retire()
    {
        Time.timeScale = 1;
        FadeManager.FadeOut(2);
    }
}
