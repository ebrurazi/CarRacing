using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject gameOverPanel;
    public Text scoreText;
    public Text finalScoreText;
    public Text highScoreText;

    public float scoreSpeed = 5f;
    private float score = 0f;
    private const string HighScoreKey = "High Score";

    public float difficulty = 1f;
    public float difficultyIncreaseRate = 0.05f;

    public AudioClip crashSound;
    public AudioClip clickSound;
    public AudioClip engineSound;

    public CameraShake cameraShake;

    private AudioSource audioSource;
    private bool isGameOver = false;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        audioSource = GetComponent<AudioSource>();

        if (engineSound != null)
        {
            audioSource.clip = engineSound;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

    void Start()
    {
        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);

        score = 0f;
        difficulty = 1f;

        if (scoreText != null)
            scoreText.text = "0";
    }

    void Update()
    {
        if (isGameOver) return;

        score += scoreSpeed * Time.deltaTime;
        difficulty += difficultyIncreaseRate * Time.deltaTime;

        if (scoreText != null)
            scoreText.text = Mathf.FloorToInt(score).ToString();
    }

    public void GameOver()
    {
        if (isGameOver) return;
        isGameOver = true;

        if (audioSource != null)
        {
            audioSource.Stop();
            if (crashSound != null)
                audioSource.PlayOneShot(crashSound);
        }

        if (cameraShake != null)
            cameraShake.Shake(0.25f, 0.3f);

        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);

        int finalScore = Mathf.FloorToInt(score);
        int highScore = PlayerPrefs.GetInt(HighScoreKey, 0);

        if (finalScore > highScore)
        {
            highScore = finalScore;
            PlayerPrefs.SetInt(HighScoreKey, highScore);
        }

        if (finalScoreText != null)
            finalScoreText.text = "Score: " + finalScore.ToString();

        if (highScoreText != null)
            highScoreText.text = "Best: " + highScore.ToString();
    }

    public void Restart()
    {
        if (audioSource != null && clickSound != null)
            audioSource.PlayOneShot(clickSound);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        if (audioSource != null && clickSound != null)
            audioSource.PlayOneShot(clickSound);

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public float GetScore()
    {
        return score;
    }
}
