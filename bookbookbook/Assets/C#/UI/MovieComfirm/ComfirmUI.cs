using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ȷ���۳���Ƭ��ui
public class ComfirmUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ConfirmCanvas;

    public void Yes()
    {
        ConfirmCanvas.SetActive(false);
    }

    public void No()
    {
        ConfirmCanvas.SetActive(false);
    }
}
