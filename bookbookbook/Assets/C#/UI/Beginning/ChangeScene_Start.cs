 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//控制开始游戏界面的ui
public class ChangeScene : MonoBehaviour
{
    public GameObject Scene_one;
    public GameObject Start_Game_one;
    public GameObject Start_Game_two;
    public GameObject Setting;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        Scene_one.SetActive(false);
        Start_Game_one.SetActive(true);
    }

    public void NewGame()
    {
        Start_Game_one.SetActive(false);
        SceneManager.LoadScene("Beginner_Tutorial");
    }

    public void ReloadGame()
    {
        Start_Game_one.SetActive(false);
        Start_Game_two.SetActive(true);
    }

    public void SettingofGame()
    {
        Scene_one.SetActive(false);
        Setting.SetActive(true);
    }

    public void StartGame_ReturnBegin()
    {
        Start_Game_one.SetActive(false);
        Scene_one.SetActive(true);
    }

    public void Reload_Game()
    {
        Start_Game_one.SetActive(true);
        Start_Game_two.SetActive(false);
    }

    public void Setting_Game()
    {
            Setting.SetActive(false);
            Scene_one.SetActive(true); 
    }
}
