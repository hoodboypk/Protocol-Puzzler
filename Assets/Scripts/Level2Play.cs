using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Level2Play : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(4);
    }
}
