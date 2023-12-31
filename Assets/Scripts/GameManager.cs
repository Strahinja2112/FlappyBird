using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour {
  private int score = 0;  
  private bool gameOver = false;
  public GameObject image;  
  public TextMeshProUGUI scoreText;  

  private void Start() {
    Time.timeScale = 0;
  }

  public void IncreaseScore() {
    score++;
    scoreText.text = score.ToString();
  }

  public void GameOver() {
    image.SetActive(true);
    gameOver = true;
  }

  public void OnStart() {
    Time.timeScale = 1;
  }
}
