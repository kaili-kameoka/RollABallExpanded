using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    
    private static int Score = 0;

	public static void AddIntToScore(int addToScore)
    {
		ScoreKeeper.Score += addToScore;
	}

    public static int GetScore()
    {
        return ScoreKeeper.Score;
    }

    
}
