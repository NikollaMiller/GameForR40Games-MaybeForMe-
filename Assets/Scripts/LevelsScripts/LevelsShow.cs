using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelsShow : MonoBehaviour
{
    [SerializeField] private Text[] _levelShow;

    private void Update()
    {
        for (int i = 0; i < _levelShow.Length; i++)
        {
            _levelShow[i].text = $"{LevelControllSript._level}";
        }
    }

    public void LoadNextLevel()
    {
        LevelControllSript._level++;
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
