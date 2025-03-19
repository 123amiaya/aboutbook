using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


//将购买的碟片实例化到主场景中
public class InitalizeMovie : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject movie1;
    public Transform position1;
    public BuyMovie buyMovie;
    public GameObject Scene;

    private bool isGenerated = false;
    /*public GameObject Scene;*/
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        InitializeMovie();

    }

    private void InitializeMovie()
    {
        if (buyMovie.isBuy1 && Scene != null && Scene.activeSelf && isGenerated == false)
        {
            /*if(Scene.activeSelf)
            {*/
                GameObject instance = Instantiate(movie1, new Vector3(232, 978, 0), Quaternion.identity, position1);
            isGenerated = true;
            /*}*/
            
        }

    }


    
    
}
