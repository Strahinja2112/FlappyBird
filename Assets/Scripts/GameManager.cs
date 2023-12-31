using UnityEngine;

public class GameManager : MonoBehaviour {
  private  int score = 0;    

  public void IncreaseScore() {
    score++;
  }

  public void GameOver() {
    Debug.Log("GAME OVER");  
  }

  private void Start() {

  }
}
