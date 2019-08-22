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

    private void Start ()
    {
        Application.targetFrameRate = 60;
        Screen.SetResolution (720, 1280, true);
    }

    public void OnGameOver ()
    {
        if (gameState == GameState.PLAYING)
        {
            gameState = GameState.GAMEOVER;
            result.SetActive (true);
        }
    }
}
