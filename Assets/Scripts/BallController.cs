using System.Collections;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float baseSpeed = 8f;
    [SerializeField] private float speedIncreaseFactor = 1.05f;
    [SerializeField] private float maxSpeed = 20f;
    [SerializeField] private float resetDelay = 1.0f;

    private Rigidbody2D rb;
    private Vector2 direction;
    private float currentSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        LaunchBall();
    }

    private void LaunchBall()
    {
        currentSpeed = baseSpeed;
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(-1f, 1f);
        direction = new Vector2(x, y).normalized;
        rb.velocity = direction * currentSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        direction = rb.velocity.normalized;

        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Wall"))
        {
            currentSpeed = Mathf.Min(currentSpeed * speedIncreaseFactor, maxSpeed);
            rb.velocity = direction * currentSpeed;
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            SoundManager.PlaySound(SoundType.RaqueteHit);
        }

        if (collision.gameObject.CompareTag("Wall"))
        {
            SoundManager.PlaySound(SoundType.WallHit);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("LeftGoal"))
        {
            FindObjectOfType<GameManager>().Score("Right");
        }
        else if (other.CompareTag("RightGoal"))
        {
            FindObjectOfType<GameManager>().Score("Left");
        }
    }

    public void ResetBall()
    {
        StartCoroutine(ResetRoutine());
    }

    private IEnumerator ResetRoutine()
    {
        rb.velocity = Vector2.zero;
        transform.position = Vector2.zero;
        yield return new WaitForSeconds(resetDelay);
        LaunchBall();
    }
}
