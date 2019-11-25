using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool is_pause = false;

    // Update is called once per frame

    public void pauseToggle()
    {
        if (is_pause)
        {
            Time.timeScale = 1;
            is_pause = false;
        }
        else
        {
            Time.timeScale = 0;
            is_pause = true;
        }
    }

    public void pause()
    {
        Time.timeScale = 0;
    }

    public void play()
    {
        Time.timeScale = 1;
    }

}
