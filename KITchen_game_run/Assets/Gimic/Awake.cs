using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Awake : MonoBehaviour
{
    private GameObject sil;
    private GameObject gol;
    Vector3 l;
    Vector3 r;
    Vector3 t;
    // Start is called before the first frame update
    void Start()
    {
        sil = GameObject.Find("silver");
        gol = GameObject.Find("gold");
        t = this.gameObject.transform.position;
        l = sil.transform.position;
        r = gol.transform.position;
        t = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        l = sil.transform.position;
        r = gol.transform.position;
        if (l.x >= t.x || r.x <= t.x)
        {
            awake();
        }
    }

    void awake()
    {
        foreach (Transform child in this.gameObject.transform)
        {
            child.gameObject.SetActive(true);
        }
    }
}
