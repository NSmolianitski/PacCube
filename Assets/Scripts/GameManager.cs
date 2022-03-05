using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Button restartButton;
    [SerializeField] private Score score;

    [Header("Settings")] 
    [SerializeField] private int scoreToWin = 5;
    
    private void Awake()
    {
        restartButton.gameObject.SetActive(false);
        score.ScoreToWin = scoreToWin;
        score.WinScoreReachedEvent += HandleWin;
    }

    private void HandleWin()
    {
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}