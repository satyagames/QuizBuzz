using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class QuestionTemplate   {

	public float Qno;
	public string Question;
	public string OptionA;
	public string OptionB;
	public string OptionC;
	public string OptionD;
	public string CorrectAnswer;

	public QuestionTemplate(int newQno, string newQuestion, string newOptionA, string newOptionB, string newOptionC, string newOptionD, string newCorrectAnswer)
	{
		Qno = newQno;
		Question = newQuestion;
		OptionA = newOptionA;
		OptionB = newOptionB;
		OptionC = newOptionC;
		OptionD = newOptionD;
		CorrectAnswer = newCorrectAnswer;

	}
	
}
