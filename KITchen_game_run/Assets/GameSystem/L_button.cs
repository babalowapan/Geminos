using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L_button : MonoBehaviour
{
    public static bool l_p = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(L_push);

    }

    // Update is called once per frame
    void L_push()
    {
        l_p = true;
    }
}
