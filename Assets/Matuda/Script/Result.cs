using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{

    [SerializeField]
    private GameObject SceneChange_obj;
    void Start()
    {

        GameObject temp=GameObject.Find("ResultScoreText");
        temp.GetComponent<ScoreText>().OnStart();
        Debug.Log("Test");

    }

    // Update is called once per frame
    void Update()
    {
        //タップしたらシーン遷移
#if UNITY_EDITOR

        if (Input.GetMouseButtonDown(0)) Instantiate(SceneChange_obj);


#else
        if (Input.touchCount > 0)   Instantiate(SceneChange_obj);

      
#endif

    }
}
