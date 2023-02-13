using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    private TMP_Text _textDisplay;

	private void Start()
	{
		this._textDisplay = GetComponent<TMP_Text>();
	}

	public void UpdateText()
    {
        this._textDisplay.text = "" + ScoreKeeper.GetScore();
    }
}
