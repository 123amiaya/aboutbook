using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//���߼�������Ժ������Խ��棬�Լ���ֹ������ťͬʱ������
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
