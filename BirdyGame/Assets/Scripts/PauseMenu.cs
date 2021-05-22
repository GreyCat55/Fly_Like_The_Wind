using System.Net.Mime;
//using System.Reflection.PortableExecutable;
using System.Diagnostics;
using System.Threading;
using System.Security.Cryptography;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;

	public GameObject pauseMenu;
	
	// Update is called once per frame
	public void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			if(GameIsPaused){
				Resume();
			}else{
				Pause();
			}
		}
	}

public void Resume(){
	pauseMenu.SetActive(false);
	Time.timeScale = 1f;
	GameIsPaused = false;
}

public void Pause(){
	pauseMenu.SetActive(true);
	Time.timeScale = 0f;
	GameIsPaused = true;
}

public void LoadMenu(){
	SceneManager.LoadScene("Menu");
}

public void QuitGame(){
	UnityEngine.Debug.Log("Quitting Game");
	Application.Quit();
}

}
