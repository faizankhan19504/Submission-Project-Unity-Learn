using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ScoreDisplayText;

    private void Start()
    {
        // 1. Load and display the Best Score immediately
        DisplayBestScore();
    }

    private void DisplayBestScore()
    {
        if (DataManager.Instance != null && ScoreDisplayText != null)
        {
            // Get the data that was loaded by the DataManager's Awake() method
            int score = DataManager.Instance.highscoreData.highScore;

            // Display the best score
            ScoreDisplayText.text = $"Best Score: {score}";
        }
    }

    // This method will be called when the Play button is clicked
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Start Game");
    }

    // This method will be called when the Quit button is clicked
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting the game...");
    }
}
