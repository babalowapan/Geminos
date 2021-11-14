using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_remove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Button_f.choice)
        {
            this.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void swapUI()
    {
        
    }
}
