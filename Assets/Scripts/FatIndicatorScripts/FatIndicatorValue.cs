using UnityEngine;

public class FatIndicatorValue : MonoBehaviour
{
    [SerializeField] private GameObject DeathPanel;
    [SerializeField] private CharacterMoving _move;

    public float _fatValue;

    private Vector3 _localScale;

    private bool _die;
    private void Start()
    {
        _localScale = transform.localScale;
    }

    private void Update()
    {
        if(_fatValue < 0.01218192f)
        {
            _fatValue = 0.01218192f;
            _die = true;
        }
        else if (_fatValue > 0.96544f)
        {
            _fatValue = 0.96544f;
        }
        _localScale.x = _fatValue;
        transform.localScale = _localScale;

        if (_die)
        {
            _move.enabled = false;
            DeathPanel.SetActive(true);
        }
        else
        {
            DeathPanel.SetActive(false);
        }
    }
}
