using UnityEngine;

public class GameManager : MonoBehaviour {
  private  int score = 0;    

  private void IncreaseScore() {
    score++;
  }

  private void GameOver() {
    Debug.Log("GAME OVER");  
  }

  private void Start() {

  }
}
