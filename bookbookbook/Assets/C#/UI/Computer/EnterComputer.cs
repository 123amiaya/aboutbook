using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//射线检测点击电脑后进入电脑界面，以及防止两个按钮同时被按下
public class EnterComputer : MonoBehaviour
{
    public GameObject Computer;
    public GameObject Scene;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void EntertoComputer()
    {
        Computer.SetActive(true);
        Scene.SetActive(false);
    }


}
