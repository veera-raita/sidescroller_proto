using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button StartButton;
    public Button QuitButton;

    public AudioClip MenuClick;
    public AudioSource MenuClickPlayer;
    // Start is called before the first frame update
    void Start()
    {
        StartButton.onClick.AddListener(() => Clicker());
        StartButton.onClick.AddListener(() => SceneStart());
        QuitButton.onClick.AddListener(() => Clicker());
        QuitButton.onClick.AddListener(() => QuitGame());
    }

    private void Clicker()
    {
        MenuClickPlayer.PlayOneShot(MenuClick, 1.0f);
    }

    private void SceneStart()
    {
        SceneManager.LoadScene(1);
    }
    private void QuitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
