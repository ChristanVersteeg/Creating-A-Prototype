using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class ExitButton_L7 : MonoBehaviour
{
	public void ExitGame()
	{
		Application.Quit();
		Debug.Log("We are out of the game");
	}
}