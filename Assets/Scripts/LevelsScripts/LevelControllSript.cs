﻿using UnityEngine;

public class LevelControllSript : MonoBehaviour
{
    public static bool _isFinished;
    public static int _level;

    private void Start()
    {
        _level = PlayerPrefs.GetInt("LevelCount",_level);
    }

    private void Update()
    {
        PlayerPrefs.SetInt("LevelCount", _level);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _isFinished = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _isFinished = false;
    }
}
