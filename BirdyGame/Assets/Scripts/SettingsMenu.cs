//using System.Reflection.Metadata.Ecma335;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
	public AudioMixer audioMixer;


	/*
		Mathf.Log10(volume) * 20 logarithmically scales the slider instead of linear scaling 
		(the range used to be -30 db to 20 db and increments/decrements by a value of 1; now range is 0.0001 to 1 and volume scales from 0 - 100%)
	 */
	public void setMasterVolume(float volume)
	{
		audioMixer.SetFloat("Master", Mathf.Log10(volume) * 20);
	}

	public void setMusicVolume(float volume)
	{
		audioMixer.SetFloat("Music", Mathf.Log10(volume) * 20);
	}

	public void setSFXVolume(float volume)
	{
		audioMixer.SetFloat("SoundEffects", Mathf.Log10(volume) * 20);
	}

	public void SetQuality(int qualityIndex)
	{
		QualitySettings.SetQualityLevel(qualityIndex);
	}

	public void SetFullscreen(bool isFullscreen)
	{
		Screen.fullScreen = isFullscreen;
	}



}
