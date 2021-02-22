using UnityEngine;

public class TrapColoring : MonoBehaviour
{
    [SerializeField] private Material[] _colors;
    [SerializeField] private HealthOfTrap _healthVal;
    private Rigidbody _mass;

    private MeshRenderer ColoringObject;
    private void Start()
    {
        _mass = GetComponent<Rigidbody>();
        ColoringObject = GetComponent<MeshRenderer>();
        if (_healthVal._healthOfTrap <= 10)
        {
            ColoringObject.material = _colors[0];
            _mass.mass = 3000;
        }
        else if (_healthVal._healthOfTrap > 10 && _healthVal._healthOfTrap < 20)
        {
            ColoringObject.material = _colors[1];
            _mass.mass = 6000;
        }
        else if (_healthVal._healthOfTrap >= 20 && _healthVal._healthOfTrap < 30)
        {
            ColoringObject.material = _colors[2];
            _mass.mass = 9000;
        }
        else if (_healthVal._healthOfTrap >= 30 && _healthVal._healthOfTrap < 40)
        {
            ColoringObject.material = _colors[3];
            _mass.mass = 12000;
        }
        else if (_healthVal._healthOfTrap >= 40 && _healthVal._healthOfTrap < 50)
        {
            ColoringObject.material = _colors[4];
            _mass.mass = 15000;
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
