using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreTextUi;
    public Text gameOverTextUi;
    public Button playButton;

    private int userScore = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start"); 
        Pause();
        gameOverTextUi.gameObject.SetActive(false);
    }
    public void Pause() {
        Time.timeScale = 0f;
        playButton.gameObject.SetActive(true);
    }
    public void Play() {
        Debug.Log("Play game");
        userScore = 0;
        scoreTextUi.text = "0";
        gameOverTextUi.gameObject.SetActive(false);
        playButton.gameObject.SetActive(false);
        Time.timeScale = 1f;
        //get all pipe
        PipeScrip[] pips = FindObjectsByType<PipeScrip>(FindObjectsSortMode.None);
        foreach (PipeScrip p in pips)
        {
            Destroy(p.gameObject);//delete pipes
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
     public void IncreaseScore() {
        userScore++;
        Debug.Log(userScore);
        scoreTextUi.text = userScore.ToString();
    }
    public void GameOver() {
        userScore = 0;
        Debug.Log("Game Over");
        scoreTextUi.text = userScore.ToString();
        gameOverTextUi.gameObject.SetActive(true);
        Pause();
    }
}
