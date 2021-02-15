using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControllScript : MonoBehaviour
{
    [SerializeField] private GameObject MenuPanel;
    [SerializeField] private GameObject GamePanel;
    [SerializeField] private CharacterMoving _move;
    private void Awake()
    {
        _move.enabled = false;
        MenuPanel.SetActive(true);
        GamePanel.SetActive(false);
    }

    public void Play() 
    {
        
        _move.enabled = true;
        MenuPanel.SetActive(false);
        GamePanel.SetActive(true);
    }

    public void Respawn() 
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
