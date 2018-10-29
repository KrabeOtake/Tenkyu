using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
private static GameManager Instance = null;
public Canvas canvasUI;
public Text text;

	void Awake()
	{
	 if (Instance == null)
			 Instance = this;
	 else if(Instance == this)
		 Destroy(gameObject);

	 InitializeManager();
	}

	private void InitializeManager()
	{
    canvasUI = GameObject.FindWithTag("UI").GetComponent<Canvas>();
		text = GameObject.FindWithTag("UIText").GetComponent<Text>();
  }

	public static void ShowWinUI()
	{
		Instance.canvasUI.gameObject.SetActive(true);
		Instance.text.text = "Level complete!";
		Instance.text.color = Color.green;
	}

	public static void ShowLoseUI()
	{
		Instance.canvasUI.gameObject.SetActive(true);
		Instance.text.text = "Lose!";
		Instance.text.color = Color.red;
	}

	public static void Restart()
	{
		Instance.StartCoroutine(Wait());
	}

	static IEnumerator Wait()
	{
		yield return new WaitForSeconds(3);
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
