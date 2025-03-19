using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//控制碟片商场中的金币
public class MoneyOwn : MonoBehaviour
{
    public Text MoneyText;
    public Text MoneyTextMain;
    public int MoneyAmount = 100;
    // Start is called before the first frame update
    void Start()
    {
       /* MoneyText.text = $"持有金币:{MoneyAmount}";*/
    }

    // Update is called once per frame
    void Update()
    {
        MoneyText.text = $"持有金币:{MoneyAmount}";
        MoneyTextMain.text = $"金币:{MoneyAmount}";
    }
}
