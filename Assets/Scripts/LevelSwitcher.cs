using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitcher : MonoBehaviour
{

    public string _nextScene;

	


	public void SwitchLevel()
	{
		SceneManager.LoadScene(this._nextScene);
	}
}
