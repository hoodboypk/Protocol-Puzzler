using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void ExitGame()
    {
        SceneManager.LoadSceneAsync(0);
    }
}

