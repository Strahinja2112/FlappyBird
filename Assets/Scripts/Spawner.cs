using UnityEngine;

public class Spawner : MonoBehaviour {
  public GameObject prefab;
  public float spawnRate = 1f;
  public float minHeight = -1f;
  public float maxHeight = 1f;

  public float difference = 0.1f;

  private void OnEnable() {
    InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
  }

  private void OnDisable() {
    CancelInvoke(nameof(Spawn));
  }

  private void Spawn() {
    GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);

    GameObject topPipe = pipes.transform.Find("PipeTop").gameObject; 
    GameObject bottomPipe = pipes.transform.Find("PipeBottom").gameObject; 

    float randomTop = Random.Range(minHeight + difference, maxHeight);
    float randomBottom = Random.Range(minHeight, maxHeight + difference);

    topPipe.transform.position += Vector3.up * randomTop;
    bottomPipe.transform.position += Vector3.down * randomBottom;

    difference -= 0.05f;

    Debug.Log(difference + "top: " + randomTop + " bottom: " + randomBottom);
  }
}
