//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.SceneManagement;

//public class ResultDirector : MonoBehaviour
//{

//    public GameObject titleButton;
//    public GameObject continueButton;

//    void Start()
//    {
//        titleButton.SetActive(false);
//        continueButton.SetActive(false);

//    }

//    void Update()
//    {
//        if (Input.GetMouseButtonDown(0))
//        {
//            titleButton.SetActive(true);
//            continueButton.SetActive(true);
//        }
//    }

//    public void OpButtonClicked()
//    {
//        SceneManager.LoadScene("OP");
//    }

//    public void ContinueButtonClicked()
//    {
//        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
//    }
//}
