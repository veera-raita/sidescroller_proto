using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCooker : MonoBehaviour
{
    public TMP_Text ScoreDisplay;
    public float ScoreCount = 0;
    void Start()
    {
        
    }

    void Update()
    {
        ScoreCount = ScoreCount + 1 * Time.deltaTime;
        ScoreDisplay.text = ((int)ScoreCount).ToString();
    }
}
