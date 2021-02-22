using UnityEngine;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    [SerializeField] private Slider _MusicVolume;
    [SerializeField] private Slider _SoundVolume;
    [SerializeField] private Animator _settingBarAnim;
    [SerializeField] private GameObject SettingsPanel;
    [SerializeField] private AudioSource Music;
    [SerializeField] private AudioSource Sound;


    private void Start()
    {
        _SoundVolume.value = PlayerPrefs.GetFloat("SoundSet", _SoundVolume.value);
        _MusicVolume.value = PlayerPrefs.GetFloat("MusicSet", _MusicVolume.value);
    }

    private void Update()
    {
        Music.volume = _MusicVolume.value;
        Sound.volume = _SoundVolume.value;

        _MusicVolume.maxValue = 0.4f;
        _SoundVolume.maxValue = 0.8f;

        PlayerPrefs.SetFloat("SoundSet", _SoundVolume.value);
        PlayerPrefs.SetFloat("MusicSet", _MusicVolume.value);
    }

    public void ClickOpenSettings() 
    {
        SettingsPanel.SetActive(true);
    }

    public void ClickCloseSettings() 
    {
        _settingBarAnim.SetInteger("Opened",1);
        Invoke("destroySettingsBarAfterAnim",1);
    }

    private void destroySettingsBarAfterAnim() 
    {
        SettingsPanel.SetActive(false);
    }
}
