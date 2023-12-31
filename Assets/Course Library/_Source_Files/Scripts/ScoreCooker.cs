using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCooker : MonoBehaviour
{
    public TMP_Text ScoreDisplay;
    public int ScoreCount = 0;
    public bool GameOverChecker;
    public AudioClip scoreGet;
    public AudioSource scoreSource;

    void Start()
    {
        
    }

    void OnTriggerEnter(Collider scoreMeme)
    {
        if (scoreMeme.CompareTag("Score") && GameObject.Find("Player").GetComponent<PlayerController>().GameOver == false)
        {
            ScoreCount++;
            ScoreDisplay.text = ScoreCount.ToString();
            scoreSource.PlayOneShot(scoreGet, 1.0f);
            Destroy(scoreMeme.gameObject);
        }

    }

    void Update()
    {

    }
}
