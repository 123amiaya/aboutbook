using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;




//�������������Ƭ�󣬳���ȷ�Ͻ��棬���ȷ�Ϻ�����(��Ҫ�й˿�ʱ�ſ��������� ��ֹ��������һ�ε���ĵ�Ƭ���ٴ�����ʱ�Ὣ������Ƭһͬ�۳�

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

    void OnButtonClicked() // ����������ڰ�ť����ʱ����ִ��
    {
        if (clickedButton != null)
        {
            clickedButton.gameObject.SetActive(false);
        }
    }

    void OnButtonClicked1() // ����������ڰ�ť����ʱ����ִ��
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
