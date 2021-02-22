using UnityEngine;

public class ExitFromWelcomePage : MonoBehaviour
{
    [SerializeField] private GameObject MainUI;
    [SerializeField] private GameObject _panelBetween;
    [SerializeField] private GameObject _WelcomeUI;
    [SerializeField] private Animator WelcomeBarAnim;

    private int _exitVal;

    private void Awake()
    {
        _exitVal = PlayerPrefs.GetInt("Exited", _exitVal);
        if (_exitVal == 0)
        {
            MainUI.SetActive(false);
            _WelcomeUI.SetActive(true);
        }
        else
        {
            MainUI.SetActive(true);
            _WelcomeUI.SetActive(false);
        }
        _panelBetween.SetActive(false);
    }

    public void ClickExitFromWelcome() 
    {
        _exitVal = 1;
        WelcomeBarAnim.SetInteger("Exiting",1);
        Invoke("destroyWelcomeUI",1);
        Invoke("DestroyBetweenPanel",2.7f);
        PlayerPrefs.SetInt("Exited",_exitVal);
    }

    private void destroyWelcomeUI()
    {
        _WelcomeUI.SetActive(false);
        _panelBetween.SetActive(true);
    }

    private void DestroyBetweenPanel() 
    {
        _panelBetween.SetActive(false);
        MainUI.SetActive(true);
    }
}
