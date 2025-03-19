using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


//在主场景中，将鼠标移动到碟片上方出现介绍
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
