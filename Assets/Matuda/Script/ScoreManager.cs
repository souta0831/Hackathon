using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 class ScoreManager : MonoBehaviour
{
    public float _now_score=0;
    [SerializeField]
    private Text DrawText;
    [SerializeField]
   private PedalManager Pedal;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _now_score += Pedal.GetNowSpeed()/100 ;
        DrawText.text =  (int)_now_score+"m";
    }
}
