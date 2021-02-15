using UnityEngine;

public class TriggerOfTrap : MonoBehaviour
{
    private FatIndicatorValue _fat;
    private CharacterMoving _scale;

    private bool triggered;
    private void Start()
    {
        _scale = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMoving>();
        _fat = GameObject.FindGameObjectWithTag("Fat").GetComponent<FatIndicatorValue>();
    }

    private void Update()
    {
        if (triggered)
        {
            _fat._fatValue -= 0.01f;
            _scale._character.transform.localScale = new Vector3(_scale._character.transform.localScale.x - 0.01f, _scale._character.transform.localScale.y - 0.01f, _scale._character.transform.localScale.z - 0.01f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            triggered = true;
            _scale.Speed = 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        triggered = false;
        _scale.Speed = 3;
    }
}
