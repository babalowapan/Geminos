using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public int scene = 5;
    // Update is called once per frame

    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(Start_Game);
    }

    public void Start_Game()
    {
        
        FadeManager.FadeOut(scene);

    }
}
