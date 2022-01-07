using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pau_ui : MonoBehaviour
{
    public static bool gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = false;
        gameObject.GetComponent<Button>().onClick.AddListener(rem);
    }

    // Update is called once per frame
    void rem()
    {
        gm = true;
    }
}
