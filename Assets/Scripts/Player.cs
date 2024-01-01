using UnityEngine;

public class Player : MonoBehaviour {
  public Sprite[] sprites;
  public float gravity = -9.8f;

  [SerializeField]
  private float strength = 5f;

  private Vector3 direction;
  private SpriteRenderer spriteRenderer;
  private int spriteIndex;

  private void Awake() {
    spriteRenderer = GetComponent<SpriteRenderer>();
  }

  private void Start() {
    InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
  }

  private void OnTriggerEnter2D(Collider2D other) {
    GameManager manager = FindObjectOfType<GameManager>();
    if (other.CompareTag("Obstacle")) {
      manager.GameOver();
    }
    else if (other.CompareTag("Scoring")) {
      manager.UpdateScore();
    }
  }

  private void OnEnable() {
    transform.position = new Vector2(transform.position.x, 0);
    direction = Vector3.zero;
  }

  private void AnimateSprite() {
    spriteIndex++;
    if (spriteIndex >= sprites.Length) {
      spriteIndex = 0;
    }
    spriteRenderer.sprite = sprites[spriteIndex];
  }

  private void Update() {
    // 0 je LMB, 1 MMB, 2 RMB || Input.GetMouseButtonDown(0)
    if (Input.GetKeyDown(KeyCode.Space)) {
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
