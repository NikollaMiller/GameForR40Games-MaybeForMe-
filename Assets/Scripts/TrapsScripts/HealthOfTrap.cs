using UnityEngine;
using TMPro;

public class HealthOfTrap : MonoBehaviour
{
    public float _healthOfTrap;

    [SerializeField] private TextMeshPro _ValueShow;

    private bool triggered;

    private void Awake()
    {
        if (LevelControllSript._level < 7)
        {
            _healthOfTrap = Random.Range(2, 20);
        }
        else if (LevelControllSript._level > 7 && LevelControllSript._level < 14)
        {
            _healthOfTrap = Random.Range(5, 30);
        }
        else if (LevelControllSript._level > 14 && LevelControllSript._level < 21) 
        {
            _healthOfTrap = Random.Range(5, 40);
        }
        else
        {
           _healthOfTrap = Random.Range(5, 50);
        }
    }

    private void Update()
    {

        if (triggered)
        {
            _healthOfTrap -= 0.4f;
        }
        _ValueShow.text = $"{System.Convert.ToInt32(_healthOfTrap)}";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            triggered = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        triggered = false;
    }
}
