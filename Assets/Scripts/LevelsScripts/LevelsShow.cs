using UnityEngine;
using UnityEngine.UI;

public class LevelsShow : MonoBehaviour
{
    [SerializeField] private Text _levelShow;

    private void Update()
    {
        _levelShow.text = $"{LevelControllSript._level}";
    }
}
