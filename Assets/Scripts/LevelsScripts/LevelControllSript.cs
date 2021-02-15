using UnityEngine;
using UnityEngine.SceneManagement;

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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _level += 1;
            int scene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
        }
    }

}
