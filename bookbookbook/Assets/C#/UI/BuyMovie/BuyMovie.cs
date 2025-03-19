using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;



//¹ºÂòµçÓ°
public class BuyMovie : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;


    private int num1 = 0;
    private int num2 = 0;
    private int num3 = 0;
    private int num4 = 0;
    private int num5 = 0;

    public int istrue1;
    public int istrue2;
    public int istrue3;
    public int istrue4;
    public int istrue5;

    public MoneyOwn money;

    public bool isBuy1 = false;
    private bool isBuy2 = false;
    private bool isBuy3 = false; 
    private bool isBuy4 = false;
    private bool isBuy5 = false;

    // Start is called before the first frame update
    void Start()
    {
        button1.onClick.AddListener(OnButton1Pressed);
        button2.onClick.AddListener(OnButton2Pressed);
        button3.onClick.AddListener(OnButton3Pressed);
        button4.onClick.AddListener(OnButton4Pressed);
        button5.onClick.AddListener(OnButton5Pressed);
    }

    // Update is called once per frame
    void Update()
    {
        BookMaterial();
    }


    void OnButton1Pressed()
    {
        num1++;
    }

    void OnButton2Pressed()
    {
        num2++;
    }


    void OnButton3Pressed()
    {
        num3++;
    }


    void OnButton4Pressed()
    {
        num4++;
    }


    void OnButton5Pressed()
    {
        num5++;
    }


    public void BuyButton()
    {
        if(num1 % 2 == 1 && !isBuy1)
        {
            istrue1 = 1;
            isBuy1 = true;
        }
        if (num2 % 2 == 1 && !isBuy2)
        {
            istrue2 = 1;
            isBuy2 = true;
        }
        if (num3 % 2 == 1 && !isBuy3)
        {
            istrue3 = 1;
            isBuy3 = true;
        }
        if (num4 % 2 == 1 && !isBuy4)
        {
            istrue4 = 1;
            isBuy4 = true;
        }
        if (num5 % 2 == 1 && !isBuy5)
        {
            istrue5 = 1;
            isBuy5 = true;
        }
        money.MoneyAmount -= 10 * istrue1 + 7 * istrue2 + 20 * istrue3 + 17 * istrue4 + 13 * istrue5;
        istrue1 = istrue2 = istrue3 = istrue4 = istrue5 = 0;
    }


    private void BookMaterial()
    {
        if(isBuy1)
        {
            
        }
        if(isBuy2)
        {
            Debug.Log("2");
        }
    }
}
