using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
	[SerializeField] private GameEvent _onUpdateScore;

	[SerializeField] private int _scoreToAdd = 100;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			ScoreKeeper.AddIntToScore(this._scoreToAdd);
			this._onUpdateScore.Invoke();
			gameObject.SetActive(false);			
		}
	}
}
