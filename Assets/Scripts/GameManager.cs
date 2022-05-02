using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Start(){
        DarkenMenu.SetActive(false);
        SettingPanel.SetActive(false);   // 關閉設定畫面
    }
    public GameObject SettingPanel;
    public GameObject DarkenMenu;
    public void OnStartGame(string SceneName){
        SceneManager.LoadScene(SceneName);   // 透過 SceneName 讀取場景
    }

    public void OpenSettingPanel(string SceneName){
        DarkenMenu.SetActive(true);
        SettingPanel.SetActive(true);   // 召喚設定畫面
    }
    public void ExitSettingPanel(string SceneName){
        DarkenMenu.SetActive(false);
        SettingPanel.SetActive(false);   // 關閉設定畫面
    }

    public void QuitGame()
    {
        Application.Quit(); // 關閉遊戲
    }
}
