using System.Threading;
//code by gamesplusjames

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public Text current_score;
	//public Text highest_score;

	public float scoreCount;
	//public float highestScoreCount;

	public bool scoreIncreasing;
	public float pointsPerSecond;
	
	void Update () {

	//	if(scoreIncreasing){
			scoreCount += pointsPerSecond * Time.deltaTime;
		// }
		// if(scoreCount > highestScoreCount){
		// 	highestScoreCount = scoreCount;
		// }

		current_score.text = " " + Mathf.Round(scoreCount);
		//highest_score.text = " " + Mathf.Round(highestScoreCount);


	
	}

}
