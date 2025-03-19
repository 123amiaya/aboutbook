using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



//进入碟片商店以及点击其他地方筛选菜单自动关闭
public class EnterStore : MonoBehaviour
{
    public GameObject Store;
    public GameObject SelectCanvas;
    public GameObject clickedObject;
    private string tags;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckOther();
    }

    

    public void EnterSto()
    {
        Store.SetActive(true);
    }

    public void ExitSto()
    {
        Store.SetActive(false);
    }

    public void ShowSelect()
    {
        SelectCanvas.SetActive(true);
        
    }



    private void CheckOther()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10;

            Vector3 screenPos = Camera.main.ScreenToWorldPoint(mousePos);
            RaycastHit2D hit = Physics2D.Raycast(screenPos, Vector2.zero);

            if (hit.collider != null &&  hit.collider.tag != "Tags")
            {
                SelectCanvas.SetActive(false);
                Debug.Log(hit.collider.tag);

            }
            
        }
    }
}
