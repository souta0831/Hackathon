using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{

    [SerializeField]
    Text　Result_Score;
    [SerializeField]
    GameObject obj;
    void Start()
    {
        Result_Score.text = "結果発表:"+GameObject.Find("SpeedManager").GetComponent<ScoreManager>()._now_score.ToString()+"M";
    }

    // Update is called once per frame
    void Update()
    {

#if UNITY_EDITOR

        if (Input.GetMouseButtonDown(0)) Instantiate(obj);


#else
        if (Input.touchCount > 0)   Instantiate(obj);

      
#endif

    }
}
