using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int CorrectAnswers = 0;
    int QuestionsSeen = 0;
    int WrongAnswers = 0;  

    

    public int GetCorrectAnswers()
    {
        return CorrectAnswers;
    }

    public void IncrementCorrectAnswers()
    {
        CorrectAnswers++;
    }


    public int GetWrongAnswers()

    {

        return WrongAnswers;

    }
    public int GetQuestionSeen()
    {
        return QuestionsSeen;
    }

    public void IncrementQuestionsSeen()
    {
        QuestionsSeen++;
    }

    public int CalculateScore()
    {
        return Mathf.RoundToInt(CorrectAnswers / (float)QuestionsSeen * 100);
    }
}
