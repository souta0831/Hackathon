using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField]
    public string _scene_pas;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene(_scene_pas);
    }
}