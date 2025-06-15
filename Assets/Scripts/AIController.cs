using UnityEngine;

public class AIController : MonoBehaviour
{
    [SerializeField] private Transform ball;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float predictionThreshold = 0.25f;
    [SerializeField] private float inaccuracyChance = 0.2f;
    [SerializeField] private float maxOffset = 0.5f;
    [SerializeField] private float minY = -4f;
    [SerializeField] private float maxY = 4f;

    private Rigidbody2D rb;
    private float targetY;
    private Vector3 startPosition;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
    }

    private void FixedUpdate()
    {
        if (ball == null) return;

        if (ball.GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            float distance = Mathf.Abs(ball.position.y - transform.position.y);
            targetY = ball.position.y;

            if (distance > predictionThreshold && Random.value < inaccuracyChance)
            {
                float offset = Random.Range(-maxOffset, maxOffset);
                targetY += offset;
            }
        }

        float direction = 0f;
        if (Mathf.Abs(targetY - transform.position.y) > 0.1f)
        {
            direction = targetY > transform.position.y ? 1f : -1f;
        }

        float newY = Mathf.Clamp(transform.position.y + direction * moveSpeed * Time.fixedDeltaTime, minY, maxY);
        rb.MovePosition(new Vector2(transform.position.x, newY));
    }

    public void ResetPosition()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}