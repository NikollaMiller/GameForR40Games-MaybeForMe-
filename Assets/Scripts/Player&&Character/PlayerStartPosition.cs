using UnityEngine;

public class PlayerStartPosition : MonoBehaviour
{
    private Transform _player;

    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        _player.transform.position = transform.position;
    }
}
