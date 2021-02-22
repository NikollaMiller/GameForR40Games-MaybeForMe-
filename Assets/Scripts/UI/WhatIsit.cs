using UnityEngine;
using UnityEngine.SceneManagement;

public class WhatIsit : MonoBehaviour
{
    private int _finishedPremer;

    private void Awake()
    {
        _finishedPremer = PlayerPrefs.GetInt("Finished", _finishedPremer);
        if (_finishedPremer == 1)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void ClickTOFinishThisShit() 
    {
        _finishedPremer = 1;
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("Finished",_finishedPremer);
    }
}
