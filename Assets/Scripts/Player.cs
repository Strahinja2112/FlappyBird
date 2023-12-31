using UnityEngine;

public class Player : MonoBehaviour {
  public float gravity = -9.8f;
  [SerializeField]
  private float strength = 5f;

  private Vector3 direction;

  private void Update() {
    // 0 je LMB, 1 MMB, 2 RMB
    if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
      direction = Vector3.up * strength;
    }

    // mobile touch
    if (Input.touchCount > 0) {
      Touch touch = Input.GetTouch(0);

      if (touch.phase == TouchPhase.Began) {
        direction = Vector3.up * strength;
      }
    }

    direction.y += gravity * Time.deltaTime;
    transform.position += direction * Time.deltaTime;
  }
}
