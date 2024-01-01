using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour {
  private int score = 0;  

  public GameObject gameOver; 
  public GameObject playButton; 
  public Player player; 
  public TextMeshProUGUI scoreText;  

  private void Awake() {
    Application.targetFrameRate = 120;
    Pause();
  }

  public void UpdateScore() {
    score++;
    scoreText.text = score.ToString();
  }

  public void UpdateScore(int newScore) {
    score = newScore;
    scoreText.text = score.ToString();
  }

  public void Pause() {
    Time.timeScale = 0f;
    player.enabled = false;
  }

  public void Play() {
    Time.timeScale = 1f;
    player.enabled = true;
    
    gameOver.SetActive(false);
    playButton.SetActive(false);
    
    UpdateScore(0);
  }

  public void PlayPause() {
    if (Time.timeScale == 0) {
      Time.timeScale = 1;
    }
    else {
      Time.timeScale = 0;
    }
  }

  public void GameOver() {
    gameOver.SetActive(true);
    playButton.SetActive(true);
    Pause();
  }
}
