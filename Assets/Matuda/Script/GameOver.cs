using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject titleButton;
    public GameObject continueButton;
    public GameObject panel;
    public GameObject panel2;
    public GameObject moveText;
    public Text mileageText;
    public AudioSource gameBgm;

    public AudioClip gameoverSE;
    public AudioClip tapSE;

    public float speed = 0.005f;
    float alfa;
    float red, green, blue;

    int fadeout_frag;
    bool se_flag;

    AudioSource audioSource1;
    AudioSource audioSource2;
    public GameObject fadeout_obj; 
    void Start()
    {

        red = panel.GetComponent<Image>().color.r;
        green = panel.GetComponent<Image>().color.g;
        blue = panel.GetComponent<Image>().color.b;

        fadeout_frag = 0;
        se_flag = true;

        titleButton.SetActive(false);
        continueButton.SetActive(false);
        panel2.SetActive(false);
        moveText.SetActive(false);

        audioSource1 = GetComponent<AudioSource>();
        audioSource2 = GetComponent<AudioSource>();
    }

    void Update()
    {

        //倒れたときの処理
        

        if (fadeout_frag == 1)
        {
            alfa += speed;

            if (alfa >= 0.5)
            {
                speed = 0;
            }

            panel.GetComponent<Image>().color = new Color(red, green, blue, alfa);
        }
    }


    public void OnGameOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fadeout_obj);

            if (se_flag == true)
            {
                audioSource1.PlayOneShot(gameoverSE);
                se_flag = false;
            }

            fadeout_frag = 1;
        }
    }
    public void OpButtonClicked()
    {
        audioSource2.PlayOneShot(tapSE);
        //SceneManager.LoadScene("OP");
    }

    public void ContinueButtonClicked()
    {
        audioSource2.PlayOneShot(tapSE);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
