using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelsShow : MonoBehaviour
{
    [SerializeField] private Text[] _levelShow;
    [SerializeField] private GameObject _wonPanel;

    private void Update()
    {
        for (int i = 0; i < _levelShow.Length; i++)
        {
            _levelShow[i].text = $"{LevelControllSript._level}";
        }

        if (LevelControllSript._isFinished)
        {
            _wonPanel.SetActive(true);
        }
        else
        {
            _wonPanel.SetActive(false);
        }
    }

    public void LoadNextLevel()
    {
        LevelControllSript._level++;
        _wonPanel.SetActive(false);
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
