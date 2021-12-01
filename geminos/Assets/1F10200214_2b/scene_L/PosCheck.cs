using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PosCheck : MonoBehaviour
{
    [SerializeField]
    float positionY = -45;

    Transform player;
    GameManager gameManager;

    void Start()
    {
        player = this.gameObject.transform;
        gameManager = GetComponent<GameManager>();
    }

    void Update()
    {
        if (player.position.y <= positionY)
        {
            FadeManager.FadeOut(2);
        }
    }
}
