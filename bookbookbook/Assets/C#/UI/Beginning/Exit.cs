using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//用于控制在开始游戏界面退出游戏
public class Exit : MonoBehaviour
{
    // Start is called before the first frame update
    

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//在Unity编译器中结束运行
#else
    Application.Quit();//在可执行程序中结束运行
#endif
    }
}
