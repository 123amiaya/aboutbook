using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//���ڿ����ڿ�ʼ��Ϸ�����˳���Ϸ
public class Exit : MonoBehaviour
{
    // Start is called before the first frame update
    

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//��Unity�������н�������
#else
    Application.Quit();//�ڿ�ִ�г����н�������
#endif
    }
}
