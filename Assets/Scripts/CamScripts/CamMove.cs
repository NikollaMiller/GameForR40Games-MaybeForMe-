using UnityEngine;

public class CamMove : MonoBehaviour
{
    [SerializeField] private Transform _character;
    [SerializeField] private Transform cam;
    private float smooth = 5.0f;
    private Vector3 offsetx = new Vector3(0, 4.66f, -5.73f);
    private Vector3 offsetz = new Vector3(-4.88f, 4.66f, 0);
    private Vector3 offsetMinusZ = new Vector3(4.88f, 4.66f, 0);
    private void Update()
    {
        if (RoatationPlayer.rotated == 1)
        {
            cam.rotation = Quaternion.Euler(cam.rotation.x, 90f, cam.rotation.z);
            transform.position = Vector3.Lerp(transform.position, _character.position + offsetz, Time.deltaTime * smooth);
        }
        else if(RoatationPlayer.rotated == 0)
        {
            cam.rotation = Quaternion.Euler(cam.rotation.x, 0, cam.rotation.z);
            transform.position = Vector3.Lerp(transform.position, _character.position + offsetx, Time.deltaTime * smooth);
        }
        else
        {
            cam.rotation = Quaternion.Euler(cam.rotation.x, -90, cam.rotation.z);
            transform.position = Vector3.Lerp(transform.position, _character.position + offsetMinusZ, Time.deltaTime * smooth);
        }
    }
}
