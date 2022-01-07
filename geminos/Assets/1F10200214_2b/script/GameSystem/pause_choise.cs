using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pause_choise : MonoBehaviour
{
    public static bool rem;
    // Start is called before the first frame update
    void Start()
    {
        if (Button_f.choice)
        {
            this.gameObject.SetActive(false);
        }
        rem = false;
        gameObject.GetComponent<Button>().onClick.AddListener(re);
    }

    // Update is called once per frame
    void re()
    {
        rem = true;
        Debug.Log("!!!");
    }
}
