using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakFloor : MonoBehaviour
{
    public StopFloor st;
    public static float deleteTime = 3.0f;
    // Start is called before the first frame update
    void start()
    {
        st = GetComponent<StopFloor>();
    }

    void Break()
    {
        Destroy(this.gameObject, deleteTime);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (st.IsFloor())
        {
            Break();
        }*/
    }
}
