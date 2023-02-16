using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScaler : MonoBehaviour
{
    [SerializeField] private AudioClip _audioClip;

	private AudioSource _audioSouurce;

	private void Start()
	{
		this._audioSouurce = GetComponent<AudioSource>();    
	}

	public void UpdateScale()
    {
        float scaleToAdd = ScoreKeeper.GetScore() / 100f;
        Vector3 newScale = transform.localScale;
        newScale.x += scaleToAdd;
        newScale.y += scaleToAdd;
        newScale.z += scaleToAdd;
        transform.localScale = newScale;
    }

    public void PlaySound()
    {
        this._audioSouurce.clip = this._audioClip;
        this._audioSouurce.Play();
    }
}
