using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCooker : MonoBehaviour
{
    public TMP_Text ScoreDisplay;
    public float ScoreCount = 0;
    public bool GameOverChecker;

    void Start()
    {
        
    }

    void Update()
    {
        GameOverChecker = GameObject.Find("Player").GetComponent<PlayerController>().GameOver;
        if (!GameOverChecker)
        {
            ScoreCount = ScoreCount + 1 * Time.deltaTime;
            ScoreDisplay.text = ((int)ScoreCount).ToString();
        }
    }
}
