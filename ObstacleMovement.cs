using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float baseSpeed = 5f;
    public float destroyY = -10f;

    void Update()
    {
        float multiplier = 1f;

        if (GameManager.Instance != null)
            multiplier = GameManager.Instance.difficulty;

        float speed = baseSpeed * multiplier;

        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < destroyY)
            Destroy(gameObject);
    }
}
