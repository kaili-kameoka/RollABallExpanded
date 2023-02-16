using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class CustomUnityEvent : UnityEvent<Component, object> { }

internal class GameEventListener : MonoBehaviour
{
	[SerializeField] private GameEvent _gameEvent;
	[SerializeField] private CustomUnityEvent _unityEvent;

	private void OnEnable()
	{
		this._gameEvent.Register(this);
		
		
	}

	private void OnDisable()
	{
		this._gameEvent.Deregister(this);
	}

	public void RaiseEvent(Component sender, object data)
	{
		this._unityEvent.Invoke(sender, data);
	}
}