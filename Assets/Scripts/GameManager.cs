using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour {
  public int Score { get; private set; } = 0;  

  public Spawner spawner;
  public GameObject gameOver; 
  public GameObject playButton; 
  public Player player; 
  public TextMeshProUGUI scoreText;  

  private void Awake() {
    Application.targetFrameRate = 120;
    Pause();
  }

  public void UpdateScore() {
    Score++;
    scoreText.text = Score.ToString();
  }

  public void UpdateScore(int newScore) {
    Score = newScore;
    scoreText.text = Score.ToString();
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

    Pipe[] pipes = FindObjectsOfType<Pipe>();
    foreach (var pipe in pipes) {
      Destroy(pipe.gameObject); 
    }
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
    spawner.difference = 0f;
    Pause();
  }
}
