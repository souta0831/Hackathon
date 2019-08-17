using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PedalButton : MonoBehaviour
{
    [SerializeField]
    private Sprite _on;
    [SerializeField]
    private Sprite _off;
    [SerializeField]
    PedarState _my_pedar_state;
    [SerializeField]
    PedalManager manager;

    private Image my_image;
    
    void Start()
    {
        my_image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_my_pedar_state == manager.GetNowPedar())
        {
            my_image.sprite = _on;

        }
        else
        {
            my_image.sprite = _off;
        }

    }
    public void Click()
    {
        if (manager.GetNowPedar() == _my_pedar_state)
        {
            manager.OnAddSpeed();
        }
    }
}
