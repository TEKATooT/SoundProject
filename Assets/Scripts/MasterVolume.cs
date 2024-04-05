using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class MasterVolume : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixerGroup;

    [SerializeField] private AudioSource _buttonOneSound;
    [SerializeField] private AudioSource _buttonTwoSound;
    [SerializeField] private AudioSource _buttonThreeSound;

    private bool _isSaundOn;
    private float _minVolume = -80;
    private float _maxVolume = 0;
    private float _nawVolume = 0;

    public void ToggleVolume(bool enable)
    {
        if (enable)
            _mixerGroup.audioMixer.SetFloat("MaxterVolume", _minVolume);
        else
            _mixerGroup.audioMixer.SetFloat("MaxterVolume", _nawVolume);
    }

    public void AllVolumeChanges(float newVolume)
    {
        _mixerGroup.audioMixer.SetFloat("MaxterVolume", Mathf.Lerp(_minVolume, _maxVolume, newVolume));
    }

    public void MusicVolumeChanges(float newVolume)
    {
        _mixerGroup.audioMixer.SetFloat("MusicVolume", Mathf.Lerp(_minVolume, _maxVolume, newVolume));
    }

    public void EffectsVolumeChanges(float newVolume)
    {
        _mixerGroup.audioMixer.SetFloat("EffectsVolume", Mathf.Lerp(_minVolume, _maxVolume, newVolume));
    }

    public void PlaySaundFirstButton()
    {
        _buttonOneSound.Play();
    }

    public void PlaySaundSecondButton()
    {
        _buttonTwoSound.Play();
    }

    public void PlaySaundThreeButton()
    {
        _buttonThreeSound.Play();
    }
}
