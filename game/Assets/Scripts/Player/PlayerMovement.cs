using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  private Rigidbody2D body;
  [SerializeField] private float speed = 5f;

  private void Awake()
  {
    body = GetComponent<Rigidbody2D>();
  }
}