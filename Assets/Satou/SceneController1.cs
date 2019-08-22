﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ボタンを使用するためUIとSceneManagerを使用ためSceneManagementを追加
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController1 : MonoBehaviour
{

    // ボタンをクリックするとBattleSceneに移動します
    public void ButtonClicked()
    {
        SceneManager.LoadScene("Satou/DE");
    }
}