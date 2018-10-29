using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Hole"))
		{
			GameManager.Restart();
			GameManager.ShowWinUI();
			gameObject.SetActive(false);
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag("RedBall"))
		{
			GameManager.Restart();
			GameManager.ShowLoseUI();
			gameObject.SetActive(false);
		}
	}
}
