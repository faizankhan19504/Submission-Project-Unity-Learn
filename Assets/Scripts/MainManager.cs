using TMPro;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ScoreText;
    [SerializeField] private TextMeshProUGUI HighScoreText;
    private int Points;
    
    private void Start()
    {
        UpdateHighScoreUI();
    }

    public void AddPoint(int bonus)
    {
        Points += bonus;
        ScoreText.text = $"Score : {Points}";
        
        if (Points > DataManager.Instance.highscoreData.highScore)
        {
            // Update the high score value
            DataManager.Instance.highscoreData.highScore = Points;
            
            UpdateHighScoreUI();
            DataManager.Instance.SaveHighScore();
        }
    }

    private void UpdateHighScoreUI()
    {
        // Display the current high score saved in the DataManager
        if (HighScoreText != null)
        {

            int score = DataManager.Instance.highscoreData.highScore;

            HighScoreText.text = $"Best Score: {score}";
        }
    }
}
