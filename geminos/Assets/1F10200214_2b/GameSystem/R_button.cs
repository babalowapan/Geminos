using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class R_button : MonoBehaviour
{
    public static bool r_p = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(R_push);
    }

    // Update is called once per frame
    void R_push()
    {
        r_p = true;
    }
}
