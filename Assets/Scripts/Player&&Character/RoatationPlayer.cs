using UnityEngine;

public class RoatationPlayer : MonoBehaviour
{
    public static int rotated;

    private void Start()
    {
        rotated = 0;
    }

    private void Update()
    {
        print(rotated);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RotateToRight")
        {
            rotated = 1;
        }
        else if (other.tag == "RotateToLeft")
        {
            rotated = 0;
        }
        else if (other.tag == "RotateToLeftButOther")
        {
            rotated = 2;
        }
    }
}
