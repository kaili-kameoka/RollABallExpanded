using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private static int Score = 0;

    public static void AddIntToScore(int addToscore)
    {
        ScoreKeeper.Score += addToscore;
    }

    public static int GetScore()
    {
        return ScoreKeeper.Score;
    }
}
