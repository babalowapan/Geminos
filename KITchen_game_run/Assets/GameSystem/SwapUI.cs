using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapUI : MonoBehaviour
{
    private bool swap = false;
    public GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        UI.SetActive(false);
}

    // Update is called once per frame
    public void swapUI()
    {
        if (swap == false)
        {
            UI.SetActive(true);
            swap = true;
}
        else
        {
            UI.SetActive(false);
            swap = false;
        }

    }
}
