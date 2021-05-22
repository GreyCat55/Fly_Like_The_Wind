using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class UISettings : MonoBehaviour {

	public AudioMixer audioMixer;

	public static bool GameIsPaused = false;

	public GameObject pauseMenu;

	public void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			if(GameIsPaused){
				Resume();
			}else{
				Pause();
			}
		}
	}

public void Resume(){ //Pause Menu
	pauseMenu.SetActive(false);
	Time.timeScale = 1f;
	GameIsPaused = false;
}

public void Pause(){ //Pause Menu
	pauseMenu.SetActive(true);
	Time.timeScale = 0f;
	GameIsPaused = true;
}

public void LoadMenu(){ //Pause Menu
	UnityEngine.Debug.Log("Loading menu..");
}

public void QuitGame(){ //Pause Menu
	UnityEngine.Debug.Log("Quitting Game");
}

public void setVolume (float volume) //Main Menu
{
	audioMixer.SetFloat("volume", volume);
	
}

public void SetQuality (int qualityIndex) //Main Menu
{
	QualitySettings.SetQualityLevel(qualityIndex);
}

public void SetFullscreen (bool isFullscreen) //Main Menu
{
	Screen.fullScreen = isFullscreen;
}

}
