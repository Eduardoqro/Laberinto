using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Variables
    public GameObject GameOverPanel, StartGamePanel;
    //Referencia script de player
    public PlayerBehaviour player;

    // Start is called before the first frame update
    void Start()
    {
        StartGamePanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOverMenu()
    {
        GameOverPanel.SetActive(true);
        player.speed = 0f;
        player.RestartPlayerPosition();
    }

    public void StartTheGame()
    {
        StartGamePanel.SetActive(false);
        player.speed = 3.0f;
    }

    public void QuitTheGame()
    {
        Application.Quit();
    }
}
