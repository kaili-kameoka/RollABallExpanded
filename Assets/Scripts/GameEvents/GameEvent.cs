using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Event", fileName = "NewGameEvent")]
internal class GameEvent : ScriptableObject 
{
	private HashSet<GameEventListener> _listeners = new HashSet<GameEventListener>();

	public void Invoke (Component sender, object data)
	{
		foreach (GameEventListener listener in this._listeners)
		{
			listener.RaiseEvent(sender, data);
		}
	}

	public void Register (GameEventListener listener)
	{
		this._listeners.Add(listener);
	}

	public void Deregister (GameEventListener listener)
	{
		this._listeners.Remove(listener);
	}
}