using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//���Ƶ�Ƭ�̳��еĽ��
public class MoneyOwn : MonoBehaviour
{
    public Text MoneyText;
    public Text MoneyTextMain;
    public int MoneyAmount = 100;
    // Start is called before the first frame update
    void Start()
    {
       /* MoneyText.text = $"���н��:{MoneyAmount}";*/
    }

    // Update is called once per frame
    void Update()
    {
        MoneyText.text = $"���н��:{MoneyAmount}";
        MoneyTextMain.text = $"���:{MoneyAmount}";
    }
}
