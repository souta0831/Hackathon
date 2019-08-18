using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    ScoreManager _score_manager;
    Text _text;
    public void OnStart()
    {
        _text = GetComponent<Text>();
        _text.text = "結果発表:" + GameObject.Find("SpeedManager").GetComponent<ScoreManager>()._now_score.ToString() + "M";
    }
}
