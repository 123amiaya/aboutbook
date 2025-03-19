using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


//购买电影时，点击电影出现介绍以及选中电影的描边
public class Introduction : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject IntroductionofMovie;
    public GameObject MovieStore;
    public Image outline;
    private int timeofClick = 0;

    // Update is called once per frame
    void Update()
    {
        CheckOtherPlace();
    }

    

    public void EmergeIntroduction()
    {
        timeofClick++;
        if(timeofClick % 2 == 1) 
        {
            IntroductionofMovie.SetActive(true);
            outline.gameObject.SetActive(true);
        }
        else
        {
            IntroductionofMovie.SetActive(false);
            outline.gameObject.SetActive(false);
        }
        
    }


    private void Leave()
    {
        if(!MovieStore.activeSelf)
        {
            outline.gameObject.SetActive(false);
        }
    }


    private void CheckOtherPlace()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10;

            Vector3 screenPos = Camera.main.ScreenToWorldPoint(mousePos);
            RaycastHit2D hit = Physics2D.Raycast(screenPos, Vector2.zero);

            if (hit.collider != null && hit.collider.tag != "Buy" && hit.collider.tag != "Introduction")
            {
                IntroductionofMovie.SetActive(false);
            }
        }
    }


    
}
