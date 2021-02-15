using UnityEngine;

public class TrapColoring : MonoBehaviour
{
    [SerializeField] private Material[] _colors;
    [SerializeField]private HealthOfTrap _healthVal;

    private MeshRenderer ColoringObject;
    private void Start()
    {
        ColoringObject = GetComponent<MeshRenderer>();
        if (_healthVal._healthOfTrap <= 10)
        {
            ColoringObject.material = _colors[0];
        }
        else if (_healthVal._healthOfTrap > 10 && _healthVal._healthOfTrap < 20)
        {
            ColoringObject.material = _colors[1];
        }
        else if (_healthVal._healthOfTrap >= 20 && _healthVal._healthOfTrap < 30)
        {
            ColoringObject.material = _colors[2];
        }
        else if (_healthVal._healthOfTrap >= 30 && _healthVal._healthOfTrap < 40)
        {
            ColoringObject.material = _colors[3];
        }
        else if (_healthVal._healthOfTrap >= 40 && _healthVal._healthOfTrap < 50)
        {
            ColoringObject.material = _colors[4];
        }
    }

    private void Update()
    {
        if (_healthVal._healthOfTrap < 1)
        {
            Destroy(this.gameObject);
        }
    }
}
