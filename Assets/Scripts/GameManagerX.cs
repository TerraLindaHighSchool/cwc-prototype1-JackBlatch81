using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManagerX : MonoBehaviour
{
    //fields
    public ParticleSystem explosionParticle;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI winText;
    public TextMeshProUGUI loseText;
    public bool isGameActive;
    public Button restartButton;
    public Button titleScreenButton;
    public string newGameScene;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameOver()
    {
        //for when the game is over
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
        titleScreenButton.gameObject.SetActive(true);
    }

    public void Win()
    {
        //for when player wins the game
        winText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
        titleScreenButton.gameObject.SetActive(true);
    }

    public void Lose()
    {
        //for when player doesnt collect enough points
        loseText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
        titleScreenButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        //for restarting level
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void titleScreen()
    {
        //for returning to the title screen
        SceneManager.LoadScene(newGameScene);
    }



}
