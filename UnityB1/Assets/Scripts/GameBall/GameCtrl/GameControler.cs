using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControler : MonoBehaviour
{
    private static GameControler instance;
    public static GameControler Instance { get => instance; }

    public GameObject dialogPn;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("dang co 2 GameControler");
        }
    }

    public void GameOver()
    {
        dialogPn.SetActive(true);
        Time.timeScale = 0f;
    }    

    public void LoadScene()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
        Time.timeScale = 1f;
    }    
}
