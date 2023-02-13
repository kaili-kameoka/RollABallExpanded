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
		float newPlayerTransformX = this._playerTransform.position.x + this._positionOffset.x;
		float newPlayerTransformY = this._playerTransform.position.y + this._positionOffset.y;
		float newPlayerTransformZ = this._playerTransform.position.z + this._positionOffset.z;

		transform.position = new Vector3(newPlayerTransformX, newPlayerTransformY, newPlayerTransformZ);
		
	}
}
