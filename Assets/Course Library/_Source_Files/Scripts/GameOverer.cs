using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverer : MonoBehaviour
{
    public GameObject GameOverScreen;
    public bool GameOverCheck;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameOverCheck = GameObject.Find("Player").GetComponent<PlayerController>().GameOver;
        if (GameOverCheck)
        {
            Invoke("GameOverActivate", 0.5f);
        }
    }

    void GameOverActivate()
    {
        GameOverScreen.SetActive(true);
    }
}
