using UnityEngine;

public class NoMove : MonoBehaviour
{
    public static bool _noGoRight;
    public static bool _noGoLeft;

    private void Update()
    {
        print(_noGoLeft);
        print(_noGoRight);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _noGoRight = true;
            _noGoLeft = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _noGoRight = false;
    }
}
