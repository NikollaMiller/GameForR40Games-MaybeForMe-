using UnityEngine;

public class NoMoveLeft : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            NoMove._noGoLeft = true;
            NoMove._noGoRight = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        NoMove._noGoLeft = false;
    }
}
