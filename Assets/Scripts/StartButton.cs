using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    
    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
