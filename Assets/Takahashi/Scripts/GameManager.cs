using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject result;

    public void OnGameOver ()
    {
        Instantiate (result);
    }
}
