using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float startTime = 60f;
    public Text countdownText;

    private float currentTime;
    private QuizManager gameManager; // Reference to the GameManager script

    void Start()
    {
        currentTime = startTime;

        // Get a reference to the GameManager script
        gameManager = FindObjectOfType<QuizManager>();
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime < 0)
        {
            currentTime = 0;

            // Call the GameOver function from the GameManager script
            if (gameManager != null)
            {
                gameManager.GameOver();
            }
        }

        UpdateCountdownText();
    }

    void UpdateCountdownText()
    {
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
