using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour {
  private int score = 0;  
  public GameObject image;  
  public TextMeshProUGUI scoreText;  

  private void Awake() {
    Application.targetFrameRate = 120;
    Time.timeScale = 0;
  }

  public void IncreaseScore() {
    score++;
    scoreText.text = score.ToString();
  }

  public void GameOver() {
    image.SetActive(true);
    Time.timeScale = 0;
  }

  public void OnStart() {
    Time.timeScale = 1;
  }
}
