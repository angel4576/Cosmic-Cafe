using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    public void changeScene()
    {
        if(SceneVariableTracker.level == 1)
        {
            SceneManager.LoadScene("Round1");
            SceneVariableTracker.roundTimer = 60f;
        }
        if(SceneVariableTracker.level == 2)
        {
            SceneManager.LoadScene("Round2");
            SceneVariableTracker.roundTimer = 60f;
        }
        if(SceneVariableTracker.level == 3)
        {
            SceneManager.LoadScene("Round3");
            SceneVariableTracker.roundTimer = 60f;
        }
    }

    public void restart()
    {
        SceneVariableTracker.level = 1;
        SceneManager.LoadScene("Round1");
        SceneVariableTracker.roundTimer = 40f;
    }
}