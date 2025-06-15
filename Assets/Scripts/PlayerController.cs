using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private string inputAxis = "Vertical";
    [SerializeField] private float minY = -4f;
    [SerializeField] private float maxY = 4f;

    private Rigidbody2D rb;
    private Vector3 startPosition;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
    }

    private void FixedUpdate()
    {
        float move = Input.GetAxisRaw(inputAxis);
        float newY = Mathf.Clamp(transform.position.y + move * moveSpeed * Time.fixedDeltaTime, minY, maxY);
        rb.MovePosition(new Vector2(transform.position.x, newY));
    }

    public void ResetPosition()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}