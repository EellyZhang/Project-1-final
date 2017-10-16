using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour {
	public string cubeType;


	void OnMouseDown()
	{
		if (cubeType == "bronze")
		{Part2GameController.score += 1;
			Part2GameController.bronzePlayer -= 1;}

		else if (cubeType == "silver")
		{Part2GameController.score += 10;
			Part2GameController.silverPlayer -= 1;}

		else if (cubeType == "gold")
		{Part2GameController.score += 100;
			Part2GameController.goldPlayer -= 1;}


		Destroy(gameObject);

		print ("YOUR SCORE: " + Part2GameController.score);

	}
}
