using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//用于控制主场景中声音设置
public class BGM_2 : MonoBehaviour
{
    public GameObject optionPrefab;
    public GameObject parent;
    private GameObject optionPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*public void OnClickOptionsButtonHandler()
    {
        optionPanel = Instantiate(optionPrefab, new Vector3(0,0,0),Quaternion.identity);
        optionPanel.transform.SetParent(parent.GetComponent<Transform>());
        optionPanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
    }*/

}
