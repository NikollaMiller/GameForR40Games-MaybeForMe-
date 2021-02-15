using UnityEngine;

public class FatIndicatorMove : MonoBehaviour
{
    [SerializeField] private Transform _character;
    private float smooth = 10f;
    private Vector3 offset = new Vector3(0, 0.8f, 0);
    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _character.position + offset, Time.deltaTime * smooth);
        if (RoatationPlayer.rotated == 1)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, 90f, transform.rotation.z);
        }
        else if(RoatationPlayer.rotated == 0)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, 0, transform.rotation.z);
        }
        else
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, -90, transform.rotation.z);
        }
    }
}
