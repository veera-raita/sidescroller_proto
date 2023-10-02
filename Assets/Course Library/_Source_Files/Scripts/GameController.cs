using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public TMP_Text ScoreDisplay;
    public int ScoreCount;
    public GameObject GameOverScreen;
    public bool GameOverMeme;

    // Start is called before the first frame update
    void Start()
    {
        GameOverMeme = GameObject.Find("Player").GetComponent<PlayerController>().GameOver;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreDisplay.text = ScoreCount.ToString();
        if (GameOverMeme)
        {
            GameOverScreen.SetActive(true);
        }
    }
}
