using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_f : MonoBehaviour
{
    public static bool choice = false;
    // Start is called before the first frame update
    void Start()
    {
        choice = false;
        gameObject.GetComponent<Button>().onClick.AddListener(fals);
    }

    // Update is called once per frame
    void fals()
    {
        choice = true;
        FadeManager.FadeOut(1);
    }
}
