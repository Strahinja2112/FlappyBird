using UnityEngine;

public class Parallax : MonoBehaviour {
  [SerializeField]
  private MeshRenderer meshRenderer;
  [SerializeField]
  private float animationSpeed = 0.15f;

  private void Awake() {
    meshRenderer = GetComponent<MeshRenderer>();
  } 

  private void Update() {
    meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
  }
}
