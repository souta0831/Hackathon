using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState
{
    PLAYING,
    GAMEOVER
}

public class GameManager : MonoBehaviour
{
    public GameState gameState = GameState.PLAYING;
    [SerializeField] private GameObject result;

    public void OnGameOver ()
    {
        if (gameState == GameState.PLAYING)
        {
            Time.timeScale = 0f;
            gameState = GameState.GAMEOVER;
            result.SetActive (true);
        }
    }
}
