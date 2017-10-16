using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part2GameController : MonoBehaviour
{
	public static int bronzePlayer;
	public static int silverPlayer;
	public static int goldPlayer;
	public int miningSpeed;
	int timeToMine;
	public GameObject cubePrefab;

	public static int score;

	Vector3 cubePosition;
	GameObject currentCube;

	// Use this for initialization
	void Start()
	{

		bronzePlayer = 0;
		silverPlayer = 0;
		goldPlayer = 0;
		miningSpeed = 3;
		score = 0;
		timeToMine = miningSpeed;


	}

	// Update is called once per frame
	void Update()
	{

		if (Time.time > timeToMine)
		{
			
			if (bronzePlayer == 2 && silverPlayer == 2 && goldPlayer < 1)
			{
				currentCube = Instantiate(cubePrefab, new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0), Quaternion.identity);
				currentCube.GetComponent<Renderer>().material.color = Color.yellow;
				currentCube.GetComponent<CubeBehavior>().cubeType = "gold";

				goldPlayer += 1;
			}


			else if (bronzePlayer < 4)
			{
				currentCube = Instantiate(cubePrefab, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0), Quaternion.identity);
				currentCube.GetComponent<Renderer>().material.color = Color.red;
				currentCube.GetComponent<CubeBehavior>().cubeType = "bronze";

				bronzePlayer += 1;
			}

			else if (bronzePlayer >= 4)
			{
				currentCube = Instantiate(cubePrefab, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0), Quaternion.identity);
				currentCube.GetComponent<Renderer>().material.color = Color.white;
				currentCube.GetComponent<CubeBehavior>().cubeType = "silver";

				silverPlayer += 1;
			}

			print("Bronze: " + bronzePlayer + "Silver: " + silverPlayer + "Gold: " + goldPlayer);

			timeToMine += miningSpeed;
		}
	}
}




// there is no way to spawn a gold ore. Is the gold part for Final? 