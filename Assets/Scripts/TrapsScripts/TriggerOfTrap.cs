using UnityEngine;

public class TriggerOfTrap : MonoBehaviour
{
    private FatIndicatorValue _fat;
    private CharacterMoving _scale;
    [SerializeField] private HealthOfTrap _selfHEalth;

    private bool triggered;
    private void Start()
    {
        _scale = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMoving>();
        _fat = GameObject.FindGameObjectWithTag("Fat").GetComponent<FatIndicatorValue>();
    }

    private void Update()
    {
        if (_selfHEalth._healthOfTrap <= 0 && triggered)
        {
            Destroy(this);
            triggered = false;
        }

        if (triggered)
        {
            _fat._fatValue -= 0.025f;
            CharacterMoving.Speed = CharacterUpgrade.pushStrength;
            _scale._character.transform.localScale = new Vector3(_scale._character.transform.localScale.x - 0.025f, _scale._character.transform.localScale.y - 0.025f, _scale._character.transform.localScale.z - 0.025f);
        }
        else
        {
            CharacterMoving.Speed = 3;
        }
        print(triggered);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggered = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        triggered = false;
    }
}
