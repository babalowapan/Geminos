using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookCregit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(lookcregit);
    }

    // Update is called once per frame
    void lookcregit()
    {
        FadeManager.FadeOut(4);
    }
}
