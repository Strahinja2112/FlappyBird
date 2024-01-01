using UnityEngine;

public class Pipe : MonoBehaviour {
  public float movementSpeed = 5f;
  private float leftEdge;
  
  private void Start() {
    leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - transform.localScale.x;
  }

  private void Update() {
    transform.position += movementSpeed * Time.deltaTime * Vector3.left;

    if (transform.position.x < leftEdge) {
      Destroy(gameObject);
    }
  }
}
