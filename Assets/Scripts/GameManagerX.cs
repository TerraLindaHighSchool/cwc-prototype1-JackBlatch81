using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManagerX : MonoBehaviour
{
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
        }
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
        titleScreenButton.gameObject.SetActive(true);
    }

    public void Win()
    {
        winText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
        titleScreenButton.gameObject.SetActive(true);
    }

    public void Lose()
    {
        loseText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
        titleScreenButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void titleScreen()
    {
        SceneManager.LoadScene(newGameScene);
    }



}
