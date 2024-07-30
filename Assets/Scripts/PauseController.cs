using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool paused;

    public void PauseGame()
    {
        if (paused)
        { 
        Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }

        paused = !paused;
    }
}
