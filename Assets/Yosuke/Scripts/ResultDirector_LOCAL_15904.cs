using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultDirector_LOCAL_15904 : MonoBehaviour
{

    public GameObject titleButton;
    public GameObject continueButton;
    public GameObject panel;
    public GameObject panel2;
    public GameObject moveText;
    public GameObject mileageText;
    public AudioSource gameBgm;

    public AudioClip gameoverSE;
    public AudioClip tapSE;

    public float speed = 0.005f;
    float alfa;
    float red, green, blue;
    int fadeout_frag;
    AudioSource audioSource1;
    AudioSource audioSource2;

    void Start()
    {
   
        red = panel.GetComponent<Image>().color.r;
        green = panel.GetComponent<Image>().color.g;
        blue = panel.GetComponent<Image>().color.b;

        fadeout_frag = 0;

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
        if (Input.GetMouseButtonDown(0))
        {
            titleButton.SetActive(true);
            continueButton.SetActive(true);
            panel2.SetActive(true);
            moveText.SetActive(true);
            gameBgm.Stop();

            audioSource1.PlayOneShot(gameoverSE);

            fadeout_frag = 1;
        }

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


    public void OpButtonClicked()
    {
        audioSource2.PlayOneShot(tapSE);
        SceneManager.LoadScene("OP");
    }

    public void ContinueButtonClicked()
    {
        audioSource2.PlayOneShot(tapSE);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
