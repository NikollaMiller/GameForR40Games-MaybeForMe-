using UnityEngine;

public class LevelControllSript : MonoBehaviour
{
    public static int _level;

    private void Start()
    {
        _level = PlayerPrefs.GetInt("LevelCount",_level);
    }

    private void Update()
    {
        PlayerPrefs.SetInt("LevelCount", _level);
    }
}
