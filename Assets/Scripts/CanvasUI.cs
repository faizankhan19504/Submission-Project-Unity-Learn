using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasUI : MonoBehaviour
{
    [SerializeField] private Button BackToMenuButton;
    [SerializeField] private Button RestartButton;

    // This Function is called when the Restart Button is Clicked 
    public void Restart()
    {
        Debug.Log("Restart Game!");

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        Time.timeScale = 1f;
    }

    // This Function is called when the Backtomenu Button is Clicked
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
