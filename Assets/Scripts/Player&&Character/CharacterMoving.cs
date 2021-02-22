using UnityEngine;

public class CharacterMoving : MonoBehaviour
{
    public static float Speed;
    public Rigidbody _character;

    private void Start()
    {
        _character = GetComponent<Rigidbody>();
        Speed = 3;
    }

    private void Update()
    {
        if (RoatationPlayer.rotated == 0)
        {
            _character.constraints = RigidbodyConstraints.FreezePositionX;
            _character.velocity = new Vector3(_character.velocity.x, _character.velocity.y, Speed);
        }
        else if(RoatationPlayer.rotated == 1)
        {
            _character.constraints = RigidbodyConstraints.FreezePositionZ;
            _character.velocity = new Vector3(Speed, _character.velocity.y, _character.velocity.z);
        }
        else
        {
            _character.constraints = RigidbodyConstraints.FreezePositionZ;
            _character.velocity = new Vector3(-Speed, _character.velocity.y, _character.velocity.z);
        }
       
    }
}
