using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


//���������У�������ƶ�����Ƭ�Ϸ����ֽ���
public class MovieCon : MonoBehaviour
{

    
    public GameObject movie;

    private void OnMouseOver()
    {
        movie.SetActive(true);
    }

    private void OnMouseExit()
    {
        movie.SetActive(false);
    }
}
