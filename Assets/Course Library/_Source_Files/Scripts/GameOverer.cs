using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverer : MonoBehaviour
{
    public GameObject GameOverScreen;
    public bool GameOverCheck;
    public bool helpermeme = true;

    public AudioClip MenuClick;
    public AudioSource MenuClickPlayer;

    public Button RestartButton;
    public Button MenuButton;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameOverCheck = GameObject.Find("Player").GetComponent<PlayerController>().GameOver;
        if (GameOverCheck && helpermeme)
        {
            Invoke("GameOverActivate", 1.2f);
            helpermeme = false;
        }
    }
    private void Clicker()
    {
        MenuClickPlayer.PlayOneShot(MenuClick, 1.0f);
    }

    private void SceneRestart()
    {
        SceneManager.LoadScene(1);
    }
    private void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }

    void GameOverActivate()
    {
        GameOverScreen.SetActive(true);

        RestartButton.onClick.AddListener(() => Clicker());
        RestartButton.onClick.AddListener(() => SceneRestart());
        MenuButton.onClick.AddListener(() => Clicker());
        MenuButton.onClick.AddListener(() => ReturnMenu());
    }
}
