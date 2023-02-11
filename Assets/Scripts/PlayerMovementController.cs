using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
	[SerializeField] private float _forceToAdd = 5f;

	private Rigidbody _rigidbody;

	private void Start()
	{
		this._rigidbody = GetComponent<Rigidbody>();
	}

	private void FixedUpdate()
	{
		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
		this._rigidbody.AddForce(movement * this._forceToAdd);
	}
}
