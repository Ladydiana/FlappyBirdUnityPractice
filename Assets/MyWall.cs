using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyWall : MonoBehaviour
{
	public bool IsMyWall;

	public ActiveCube activeCube;

	public Text scoreText;

	private void OnCollisionEnter(Collision collision)
	{
		if(IsMyWall == true)
		{
			activeCube.score = activeCube.score - 1;

			scoreText.text = "Score: " + activeCube.score.ToString();
		} else
		{
			activeCube.score = activeCube.score + 1;

			scoreText.text = "Score: " + activeCube.score.ToString();
		}
	}
}