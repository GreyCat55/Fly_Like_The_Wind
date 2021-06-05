using System;
using System.Net.Mime;
//code by xOctoManx

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthBar : MonoBehaviour {

public GameObject bird1, bird2, bird3, gameOver;
public static int health;

public void Start(){
	health = 3;
	bird1.gameObject.SetActive (true);
	bird2.gameObject.SetActive (true);
	bird3.gameObject.SetActive (true);
	gameOver.gameObject.SetActive (false);

}

public void Update(){
	if(health > 3)
		health = 3;

		switch(health){
			case 3:
			bird1.gameObject.SetActive (true);
			bird2.gameObject.SetActive (true);
			bird3.gameObject.SetActive (true);
			break;
			case 2:
			bird1.gameObject.SetActive (true);
			bird2.gameObject.SetActive (true);
			bird3.gameObject.SetActive (false);
			break;
			case 1:
			bird1.gameObject.SetActive (true);
			bird2.gameObject.SetActive (false);
			bird3.gameObject.SetActive (false);
			break;
			case 0:
			bird1.gameObject.SetActive (false);
			bird2.gameObject.SetActive (false);
			bird3.gameObject.SetActive (false);
			//gameOver.gameObject.SetActive(true);
			SceneManager.LoadScene("MainMenu");
			//Time.timeScale = 0;
			break;
		}
}

}
