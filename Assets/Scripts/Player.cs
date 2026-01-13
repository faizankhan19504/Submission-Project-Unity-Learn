using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Encapsulation in action by using Singleton pattern
    public static Player Instance { get; private set; }
    [SerializeField] private TextMeshProUGUI GameOverUI;
    [SerializeField] private GameObject projectilePrefab;
    
    // Variables Declaration
    private float Speed = 16.0f;
    private float xRange = 9.0f;

    // Singleton logic: ensures only one Player exists in the scene
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

    private void Update()
    {
        // Abstracted movement and boundary logic into separate methods
        PlayerMovement();
        BoundaryCheck();
    }

    // Handles keyboard input for moving and firing projectiles
    private void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }

    // Constraints the player's X position to keep them inside the "xRange"
    private void BoundaryCheck()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }

    // Public function called by other script to end the game
    public void TriggerManualGameOver()
    {
        Debug.Log("Game Over!");
        Time.timeScale = 0f;
        GameOverUI.gameObject.SetActive(true);
        MainManager.Instance.UpdateHighScoreUI();
        DataManager.Instance.SaveHighScore();
    }
}
