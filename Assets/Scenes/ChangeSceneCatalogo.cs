using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneCatalogo : MonoBehaviour
{
	public void changeScene(string nameScene) {
		SceneManager.LoadScene(nameScene);
	}
}
