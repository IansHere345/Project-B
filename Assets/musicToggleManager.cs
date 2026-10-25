using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class musicToggleManager : MonoBehaviour
{
    [SerializeField] Image musicOnImage;
    [SerializeField] Image musicOffImage;
    private bool muted = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        muted = PlayerPrefs.GetInt("MusicMuted", 0) == 1;
        UpdateButtonIcon();
    }

    public void onButtonPress()
    {
        muted = !muted;
        // This is added so music properly turns on and off.
        PlayerPrefs.SetInt("MusicMuted", muted ? 1 : 0);
        PlayerPrefs.Save();
        UpdateButtonIcon();
    }
    private void UpdateButtonIcon()
    {
        if (muted == false)
        {
            musicOnImage.enabled = true;
            musicOffImage.enabled = false;
        }
        else
        {
            musicOnImage.enabled = false;
            musicOffImage.enabled = true;
        }
    }
}
//Source Used: https://www.youtube.com/watch?v=AFcHsKd_aMo&t=255s