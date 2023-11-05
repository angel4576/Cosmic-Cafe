using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void changeScene(int sceneNum)
    {
        if(sceneNum == 1)
        {
            SceneManager.LoadScene("Round1");
        }
        if(sceneNum == 2)
        {
            SceneManager.LoadScene("Round2");
        }
        if(sceneNum == 3)
        {
            SceneManager.LoadScene("Round3");
        }
    }
}