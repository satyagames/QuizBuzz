using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using com.microeyes.admob;
public class DisplayClass_ComputerProgramming : MonoBehaviour {
	public Text QuestionField;
	public Text OptionAField;
	public Text OptionBField;
	public Text OptionCField;
	public Text OptionDField;
	public Text QuestionCountText;
	public Text ScoreFieldText;

	public Button NextButton;
	public Button AButton;
	public Button BButton;
	public Button CButton;
	public Button DButton;

	public Button NextSceneButton;
	public Image transprentLayer;

	List<QuestionTemplate> Questions;

	public float ramdomNumber;
	public int QuestionCount = 0;

	public int TotalQuestionPerRound = 7;
	//public int TotalQuestionsInDataBase = 10;
	
	void Start () {
		GameControl.control.TotalRounds = GameControl.control.TotalRounds + 1;
		NextSceneButton.gameObject.SetActive (false);
		transprentLayer.gameObject.SetActive (false);
		NextButton.gameObject.SetActive (false);
		Questions = new List<QuestionTemplate> ();

		Questions.Add (new QuestionTemplate (0,"Which of the following is not logical operator?", "&","&&","!!","!","&")); 
		Questions.Add (new QuestionTemplate (1, "Which of the following cannot be checked in a switch-case statement?","Character","Integer","Float","enum","Float"));
		Questions.Add (new QuestionTemplate (2, "The keyword used to transfer control from a function back to the calling function is?","switch","goto","go back","return","return"));
		Questions.Add (new QuestionTemplate (3, "Which one is not an access modifier","Public","Private","Protected Internal","Private Internal","Private Internal"));
		Questions.Add (new QuestionTemplate (4, "Correct Declaration of Values to variables ‘a’ and ‘b’ in C# ? ","int a = 32, b = 40.6;","int a = 42; b = 40;","int a = 32; int b = 40;"," int a = b = 42;","int a = 32; int b = 40;"));
		Questions.Add (new QuestionTemplate (5, "The operator used to get value at address stored in a pointer variable is","*","&","&&","||","*"));
		Questions.Add (new QuestionTemplate (6, "A pointer is","A keyword used to create variables","A variable that stores address of an instruction","A variable that stores address of other variable","All of the above","A variable that stores address of other variable"));
		Questions.Add (new QuestionTemplate (7, "Can function definition be present in header files?","Yes","No","Depends on the compiler","Depends on the standard","Yes"));
		Questions.Add (new QuestionTemplate (8, "Arrange following datatype in order of increasing magnitude sbyte, short, long, int.","long < short < int < sbyte","sbyte < short < int < long","short < sbyte < int < long","short < int < sbyte < long","sbyte < short < int < long"));
		Questions.Add (new QuestionTemplate (9, "Which of the following is not logical(or Relational) operator?","==","!=",">","++","++"));
		Questions.Add (new QuestionTemplate (10, "Which of the following is not possible statically in C?","Jagged Array"," Rectangular Array","Cuboidal Array","Multidimensional Array","Jagged Array"));
		Questions.Add (new QuestionTemplate (11, "Which of the following uses structure?","Array of structures","Linked Lists","Binary Tree","All of the mentioned","All of the mentioned"));
		Questions.Add (new QuestionTemplate (12, "How much Bytes are stored by ‘Long’ Datatype in C# .net?","8","4","2","1","8"));
		Questions.Add (new QuestionTemplate (13, "What is Size of ‘Char’ datatype?","8bit","12bit","16bit","20bit","16bit"));
		Questions.Add (new QuestionTemplate (14, "String method used to compare two strings with each other ?","Compare To()","Compare()","Copy()","ConCat()","Compare()"));
		Questions.Add (new QuestionTemplate (15, "Which of the following statements is correct about constructors in C#.NET?","A constructor cannot be declared as private","A constructor cannot be overloaded","A constructor can be a static constructor","None of the mentioned","A constructor can be a static constructor"));
		Questions.Add (new QuestionTemplate (16, "Which method have same name as that of its class?","delete","class","constructor","None of mentioned","constructor"));
		Questions.Add (new QuestionTemplate (17, "What is return type of constructors?"," int","float","void","None of the mentioned","None of the mentioned"));
		Questions.Add (new QuestionTemplate (18, "Which of these method used to read single character from the console?"," get()","getline()","read()","readLine()","read()"));
		Questions.Add (new QuestionTemplate (19, "Which of these method used to read string from the console?","get()","getline()","read()"," readLine()"," readLine()"));
		Questions.Add (new QuestionTemplate (20, "Which among the following methods used writes characters to a string?"," StreamWriter","StreamReader","StringWriter","None of the mentioned","StringWriter"));
		Questions.Add (new QuestionTemplate (21, "What is output returned by Console if ReadLine() stores I/O error?","1"," 0"," False","I/O EXCEPTION ERROR","I/O EXCEPTION ERROR"));
		Questions.Add (new QuestionTemplate (22, "Which of these classes are used by Byte streams for input and output operation?","InputStream","InputOutputStream","Reader","All of the mentioned","InputOutputStream"));
		Questions.Add (new QuestionTemplate (23, "Which of these class contains only floating point functions?","Math","Process","System","Object","Math"));
		Questions.Add (new QuestionTemplate (24, "What is the value of double constant ‘E’ defined in Math class?","approximately 3","approximately 3.14","approximately 2.72","approximately 0","approximately 2.72"));

		/*foreach (QuestionTemplate Ques in Questions) 
		{
			//Debug.Log(Ques.Question);
		}*/
		NextButtonClick ();
	}
	public void NextScreen()
	{
		Intestinal_Ad_Load ();
		Application.LoadLevel ("GreetScene");

	}

	public void NextButtonClick()
	{
		Debug.Log ("=========================              "+Questions.Count);
		timeLeft = 10f;
		transprentLayer.gameObject.SetActive (false);
		NextButton.gameObject.SetActive (false);
		GameControl.control.ACorrectAnswer = false;
		GameControl.control.BCorrectAnswer = false;
		GameControl.control.CCorrectAnswer = false;
		GameControl.control.DCorrectAnswer = false;
		GameControl.control.AWrongAnswer = false;
		GameControl.control.BWrongAnswer = false;
		GameControl.control.CWrongAnswer = false;
		GameControl.control.DWrongAnswer = false;

		GameControl.control.isACorrect = false;
		GameControl.control.isBCorrect = false;
		GameControl.control.isCCorrect = false;
		GameControl.control.isDCorrect = false;

		AButton.interactable = true;
		BButton.interactable = true;
		CButton.interactable = true;
		DButton.interactable = true;

		QuestionCount = QuestionCount + 1;
		QuestionCountText.text = QuestionCount + "/"+TotalQuestionPerRound;

		if (QuestionCount == TotalQuestionPerRound) 
		{
			NextButton.interactable = false;
			NextButton.gameObject.SetActive(false);
			NextSceneButton.gameObject.SetActive (true);
		}

		ramdomNumber = UnityEngine.Random.Range(0, Questions.Count);
		Debug.Log ("random number =              "+ramdomNumber);
		for(int i = 0; i < Questions.Count; i++)
		{

			if (ramdomNumber == i)
			{
				QuestionField.text = Questions[i].Question;
				OptionAField.text = Questions[i].OptionA;
				OptionBField.text = Questions[i].OptionB;
				OptionCField.text = Questions[i].OptionC;
				OptionDField.text = Questions[i].OptionD;
			}
		}

	}
	public Text TimerText;
	public float timeLeft = 10f;

	IEnumerator TimerScript(){
		if (QuestionCount == TotalQuestionPerRound + 1) 
		{
			NextButton.interactable = false;
			NextButton.gameObject.SetActive(false);
			NextSceneButton.gameObject.SetActive (true);
			timeLeft = -1f;
			NextScreen();
		}
		yield return new WaitForSeconds(1f);
		timeLeft -= Time.deltaTime;
		TimerText.text = Mathf.Round(timeLeft).ToString();
		if ( Mathf.Round(timeLeft) == 0 )
		{
			NextButtonClick();

			//yield return new WaitForSeconds(1f);
			timeLeft = 10f;
		}

	}

	void Update () {

		StartCoroutine ("TimerScript");

		ScoreFieldText.text = "#:" + GameControl.control.score;
	}

	public void OptionAButton()
	{
		Correcting ();
	}
	public void OptionBButton()
	{
		Correcting ();
	}
	public void OptionCButton()
	{
		Correcting ();
	}
	public void OptionDButton()
	{
		Correcting ();
	}
	void Correcting()
	{
		for (int i = 0; i < Questions.Count; i++) {
			if (ramdomNumber == i) {

				if (Questions [i].OptionA == Questions [i].CorrectAnswer) {
					GameControl.control.ACorrectAnswer = true;
					GameControl.control.isACorrect = true;
				} else {
					GameControl.control.AWrongAnswer = true;
					GameControl.control.isACorrect = false;
				}

				if (Questions [i].OptionB == Questions [i].CorrectAnswer) {
					GameControl.control.BCorrectAnswer = true;
					GameControl.control.isBCorrect = true;
				} else {
					GameControl.control.BWrongAnswer = true;
					GameControl.control.isBCorrect = false;
				}

				if (Questions [i].OptionC == Questions [i].CorrectAnswer) {
					GameControl.control.CCorrectAnswer = true;
					GameControl.control.isCCorrect = true;
				} else {
					GameControl.control.CWrongAnswer = true;
					GameControl.control.isCCorrect = false;
				}

				if (Questions [i].OptionD == Questions [i].CorrectAnswer) {
					GameControl.control.DCorrectAnswer = true;
					GameControl.control.isDCorrect = true;
				} else {
					GameControl.control.DWrongAnswer = true;
					GameControl.control.isDCorrect = false;
				}

				RemoveQuestionsAfterDisplay ();
			}
		}

	}


	void RemoveQuestionsAfterDisplay()
	{
		transprentLayer.gameObject.SetActive (true);
		NextButton.gameObject.SetActive (true);
		for (int i = 0; i < Questions.Count; i++) {
			if (ramdomNumber == i) {
				Questions.Remove (Questions [i]);
			}
		}

	}


	public void Intestinal_Ad_Create () {
		InterstitialAd l_interAd = AdmobManager.PrepareInterstitialAd("Interstitial_1");
		l_interAd.AdUnitId = "ca-app-pub-6065714673957825/2806333668";
		l_interAd.Create();
	}
	public void Intestinal_Ad_Load () {
		InterstitialAd l_interAd = AdmobManager.Get<InterstitialAd>("Interstitial_1");
		l_interAd.Load();
	}
	public void Intestinal_Ad_Show () {
		InterstitialAd l_interAd = AdmobManager.Get<InterstitialAd>("Interstitial_1");
		l_interAd.Show();
	}

}
