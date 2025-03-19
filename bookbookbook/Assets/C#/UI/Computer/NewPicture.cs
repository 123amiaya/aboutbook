using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//在电脑界面退出游戏
public class NewPictue : MonoBehaviour
{
    public GameObject Exit;
    public GameObject Computer;
    public GameObject Origan;
    public GameObject Setting;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ExitGame()
    {
        Exit.SetActive(true);
    }

    public void ExitGameYes()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//在Unity编译器中结束运行
#else
    Application.Quit();//在可执行程序中结束运行
#endif
    }

    public void ExitGameNo()
    {
        Exit.SetActive(false);
        
    }

    public void DeleteCanvas()
    {
        Computer.SetActive(false);
        Setting.SetActive(true);
    }

    public void DeleteSetting()
    {
        Setting.SetActive(false);
        Computer.SetActive(true);
    }


    public void ExitComputer()
    {
        Computer.SetActive(false);
        Origan.SetActive(true);
    }
}
