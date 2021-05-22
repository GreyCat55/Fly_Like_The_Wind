//using System.Reflection.Metadata.Ecma335;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour {
public AudioMixer audioMixer;

public void setVolume (float volume)
{
	audioMixer.SetFloat("volume", volume);
	
}

public void SetQuality (int qualityIndex)
{
	QualitySettings.SetQualityLevel(qualityIndex);
}

public void SetFullscreen (bool isFullscreen)
{
	Screen.fullScreen = isFullscreen;
}



}
