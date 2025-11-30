using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 8f;
    public float xLimit = 2.5f;

    private bool isDead = false;

    void Update()
    {
        if (isDead) return;

        float horizontal = Input.GetAxis("Horizontal");

        if (Input.GetMouseButton(0))
        {
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (mouseWorldPos.x < transform.position.x)
                horizontal = -1f;
            else if (mouseWorldPos.x > transform.position.x)
                horizontal = 1f;
        }

        Vector3 move = new Vector3(horizontal * moveSpeed * Time.deltaTime, 0f, 0f);
        transform.Translate(move);

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -xLimit, xLimit);
        transform.position = pos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isDead) return;

        if (collision.CompareTag("Obstacle"))
        {
            isDead = true;

            if (GameManager.Instance != null)
                GameManager.Instance.GameOver();
        }
    }
}
