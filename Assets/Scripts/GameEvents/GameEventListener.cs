using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

internal class GameEventListener : MonoBehaviour
{
	[SerializeField] private GameEvent _gameEvent;
	[SerializeField] private UnityEvent	 _unityEvent;

	private void OnEnable()
	{
		this._gameEvent.Register(this);
	}

	private void OnDisable()
	{
		this._gameEvent.Deregister(this);
	}

	public void RaiseEvent()
	{
		this._unityEvent.Invoke();
	}
}