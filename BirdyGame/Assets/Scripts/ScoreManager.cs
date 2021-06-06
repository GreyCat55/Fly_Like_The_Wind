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

	/*
	 *  1) AddScore is called in ObstacleScroll.cs, which is attached to every registered obstacle in the game.
		TODO: make points from enemies more satisfying. Right now, the score is updated everytime the enemy instance 
		is deleted, which takes roughly about 10 seconds after going off screen

		make scoring more immediate or apparent - maybe score points 5 seconds after they leave the screen and also add
		some indicator to the player where they were deleted off screen (think about the magnifying glass effect from Smash Bros.)
		with the score value attached to them

		2) AddScore is also called in MovableObject.cs. If the movable object is the player's bird, then points are accumulated 
		whenever the bird is blown by the wind. The points awarded is based on the bird's acceleration influenced by the wind strength.
		
		TODO: make scoring via blowing the bird less powerful and leave no incentive for the player for blowing downwards. 
		- Maybe change the scoring system based on the wind's angle: don't grant points when the wind direction isn't propelling the bird forwards
		- Maybe add a multiplier on the timer-based score based on the bird's speed
		- OVERHAUL GAME MECHANICS: Maybe make the bird fly faster/slower whenever its blown so that the player isn't encouraged to blow the bird too often.
		  Score per second is adjusted based on how fast the bird flies (slow = less points, fast = more points)
	 */
	public void AddScore(int points) 
	{
		scoreCount += points;
	}
}
