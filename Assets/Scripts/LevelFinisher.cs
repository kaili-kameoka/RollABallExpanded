using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinisher : MonoBehaviour
{
	[SerializeField] private Animator _levelSwitcherAnimator;
	[SerializeField] private int _targetScore;
	[SerializeField] private GameEvent _onLevelFinished;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player") && this.IsLevelFinished())
		{
			this._levelSwitcherAnimator.SetTrigger("FadeOut");
			this._onLevelFinished.Invoke(this, null);
		}
	}

	private bool IsLevelFinished()
	{
		return ScoreKeeper.GetScore() > this._targetScore;
	}
}
