using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Txt_rem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Button_f.choice==false)
        {
            this.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
