using TMPro;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    // Encapsulation in action by using Singleton pattern
    public static MainManager Instance { get; private set; }
    [SerializeField] private TextMeshProUGUI ScoreText;
    [SerializeField] private TextMeshProUGUI HighScoreText;
    private int Points;
    
    // Singleton logic: ensures only one MainManager exists in the scene
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

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
        }
    }

    public void UpdateHighScoreUI()
    {
        // Display the current high score saved in the DataManager
        if (HighScoreText != null)
        {

            int score = DataManager.Instance.highscoreData.highScore;

            HighScoreText.text = $"Best Score: {score}";
        }
    }
}
