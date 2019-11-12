using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void GameStart()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void GameClose()
    {
        Application.Quit();
    }
}
