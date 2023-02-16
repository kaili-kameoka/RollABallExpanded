using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
	[SerializeField] private Vector3 _positionOffset;

	private Transform _playerTransform;

	private void Start()
	{
		GameObject player = GameObject.FindGameObjectWithTag("Player");
		this._playerTransform = player.transform;
	}

	private void Update()
	{
		Vector3 newPosition = this._playerTransform.position;
		newPosition.x += this._positionOffset.x;
		newPosition.y += this._positionOffset.y + this._playerTransform.localScale.y;
		newPosition.z += this._positionOffset.z - this._playerTransform.localScale.z;

		transform.position = newPosition;
		
	}
}
