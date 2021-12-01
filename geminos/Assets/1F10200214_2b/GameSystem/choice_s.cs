using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class choice_s : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(c);
    }

    // Update is called once per frame
    void c()
    {
        FadeManager.FadeOut(1);
    }
}
