using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{

    [SerializeField] private GameObject title;

    public void GoGameScene ()
    {
        Instantiate (title);
    }
}
