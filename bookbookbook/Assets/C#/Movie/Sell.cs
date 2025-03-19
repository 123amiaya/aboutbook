using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;




//在主场景点击碟片后，出现确认界面，点击确认后卖出(需要有顾客时才可以卖出） 防止不售卖第一次点击的碟片后再次售卖时会将两个碟片一同售出

public class Sell : MonoBehaviour
{
    /*public UnityEvent OnButtonEvent;
    public Button ButtonYes;*/
    [Header("Button Reference")]
    public GameObject MovieSellCanvas;
    public Button clickedButton;

    public Button yesbutton;
    public Button nobutton;
    // Start is called before the first frame update
    void Start()
    {
        
        yesbutton.onClick.AddListener(OnButtonClicked);
        nobutton.onClick.AddListener(OnButtonClicked1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnButtonClicked() // 这个方法会在按钮按下时立即执行
    {
        if (clickedButton != null)
        {
            clickedButton.gameObject.SetActive(false);
        }
    }

    void OnButtonClicked1() // 这个方法会在按钮按下时立即执行
    {
        if (clickedButton != null)
        {
            clickedButton = null;
        }
    }


    public void OnButtonClick()
    {
        clickedButton = GetComponent<Button>(); 
    }


    public void SellMovie()
    {
        MovieSellCanvas.SetActive(true);
    }

    
}
