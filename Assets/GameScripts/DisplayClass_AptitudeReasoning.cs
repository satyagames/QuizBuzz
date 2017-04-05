using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using com.microeyes.admob;
public class DisplayClass_AptitudeReasoning : MonoBehaviour {

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
	public int TotalQuestionsInDataBase = 92;
	
	void Start () {


		GameControl.control.TotalRounds = GameControl.control.TotalRounds + 1;
		NextSceneButton.gameObject.SetActive (false);
		transprentLayer.gameObject.SetActive (false);
		NextButton.gameObject.SetActive (false);
		Questions = new List<QuestionTemplate> ();

		Questions.Add (new QuestionTemplate (0,"A train running at the speed of 60 km/hr crosses a pole in 9 seconds. What is the length of the train?", "120 metres","180 metres","324 metres","150 metres","150 metres")); 
		Questions.Add (new QuestionTemplate (1,"How many prime numbers less than 50?", "14","16","15","18","15")); 
		Questions.Add (new QuestionTemplate (2,"If A = x% of y and B = y% of x, then which of the following is true?", "A is smaller than B.","A is greater than B","Relationship between A and B cannot be determined.","None of these","None of these")); 
		Questions.Add (new QuestionTemplate (3,"Which one of the following is not a prime number?", "31","61","71","91","91")); 
		Questions.Add (new QuestionTemplate (4,"1397 x 1397 = ?", "1951609","1981709","18362619","2031719","1951609")); 
		Questions.Add (new QuestionTemplate (5,"The largest 4 digit number exactly divisible by 88 is:", "9944","9768","9988","8888","9944"));
		Questions.Add (new QuestionTemplate (6,"(?) - 19657 - 33994 = 9999", "63650","53760","59640","61560","63650")); 
		Questions.Add (new QuestionTemplate (7,"The sum of first 45 natural numbers is:", "1035","1280","2070","2140","1035"));
		Questions.Add (new QuestionTemplate (8,"The sum of even numbers between 1 and 31 is:", "6","28","240","512","512")); 
		Questions.Add (new QuestionTemplate (9,"If a - b = 3 and a2 + b2 = 29, find the value of ab.", "10","12","15","18","10"));
		Questions.Add (new QuestionTemplate (10,"To fill a tank, 25 buckets of water is required. How many buckets of water will be required to fill the same tank if the capacity of the bucket is reduced to two-fifth of its present ?", "10","35","62.5","Cannot be determined","62.5")); 
		Questions.Add (new QuestionTemplate (11,"A person crosses a 600 m long street in 5 minutes. What is his speed in km per hour?", "3.6","7.2","8.2","8.4","7.2"));
		Questions.Add (new QuestionTemplate (12,"A is two years older than B who is twice as old as C. The total of the ages of A, B and C is 27. How old is B?", "10","9","8","7","10")); 
		Questions.Add (new QuestionTemplate (13," Today is Monday. After 61 days, it will be", "Thursday"," Sunday","Monday","Saturday","Saturday"));
		Questions.Add (new QuestionTemplate (14,"Which of the following is not a leap year?", "1200","800","700","2000","700")); 
		Questions.Add (new QuestionTemplate (15,"The price of 24 apples is equal to that of 28 oranges. The price of 45 apples and 60 oranges together is Rs.1350. The total price of 30 apples and 40 oranges is", "Rs.920","Rs.940"," Rs.880","Rs.900","Rs.900"));
		Questions.Add (new QuestionTemplate (16," 36 men can complete a piece of work in 18 days. In how many days will 27 men complete the same work?", "26","22","12","24","24")); 
		Questions.Add (new QuestionTemplate (17," Find the odd man out. 7,13,19,25,29,37,43", "19","29","25","43","25"));
		Questions.Add (new QuestionTemplate (18," Insert the missing number. 34, 7, 37, 14, 40, 28, 43, (...)", "31","42","46","56","56"));
		Questions.Add (new QuestionTemplate (19," X starts a business with Rs.45000. Y joins in the business after 3 months with Rs.30000. What will be the ratio in which they should share the profit at the end of the year? ", "1:2","2:1","1:3","3:1","2:1"));
		Questions.Add (new QuestionTemplate (20,"5216 x 51 = ? ", "266016","212016","266436","216314","266016"));
		Questions.Add (new QuestionTemplate (21,"360*17 = ?","5120","5320","6120","6130","6120"));
		Questions.Add (new QuestionTemplate (22,"Sum of two odd numbers is always  = ?","even","odd","coprime","1","even"));
		Questions.Add (new QuestionTemplate (23,"Product of two odd numbers is always  = ?","0","odd","1","even","odd"));
		Questions.Add (new QuestionTemplate (24,"The least prime number is = ?","1","2","6","0","2"));
		Questions.Add (new QuestionTemplate (25,"The average of first five multiples of 3 is = ?","3","9","12","15","9"));
		Questions.Add (new QuestionTemplate (26,"Find the odd man out. 3, 5, 11, 14, 17, 21 ?","21","17","14","3","14"));
		Questions.Add (new QuestionTemplate (27,"Find the odd man out 8, 27, 64, 100, 125, 216, 343?","27","100","125","343","100"));
		Questions.Add (new QuestionTemplate (28,"Find the odd man out 10, 25, 45, 54, 60, 75, 80?","10","45","54","75","54"));
		Questions.Add (new QuestionTemplate (29,"Which one of the following is not a prime number = ?","31","61","71","91","91"));
		Questions.Add (new QuestionTemplate (30,"(112 x 54) = ?","67000","70000","76500","77200","70000"));
		Questions.Add (new QuestionTemplate (31,"Which of the following is a prime number = ?","33","81","93","97","97"));
		Questions.Add (new QuestionTemplate (32,"(12)3 x 64 ÷ 432 = ? = ?","5184","5060","5148","5084","5184"));
		Questions.Add (new QuestionTemplate (33,"72519 x 9999  = ?","725117481","674217481","685126481","696217481","725117481"));
		Questions.Add (new QuestionTemplate (34,"(12345679 x 72) = ?","88888888","888888888","99999999","999999999","888888888"));
		Questions.Add (new QuestionTemplate (35,"2 + 22 + 23 + ... + 29 = ?","2044","1022","2201","4402","1022"));
		Questions.Add (new QuestionTemplate (36,"(22 + 42 + 62 + ... + 202)  = ?","1540","81","93","97","1540"));
		Questions.Add (new QuestionTemplate (37,"The sum of first 45 natural numbers is: = ?","1035","181","1193","197","1035"));
		Questions.Add (new QuestionTemplate (38,"The largest 4 digit number exactly divisible by 88 is: = ?","9944","9768","9988","8888","9944"));
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
		timeLeft = 15f;
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
	public float timeLeft = 15f;

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
			timeLeft = 15f;
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
					//WrongSoundAS.clip = WrongSoundAC;
					//WrongSoundAS.Play ();
				} else {
					GameControl.control.BWrongAnswer = true;
					GameControl.control.isBCorrect = false;
				}

				if (Questions [i].OptionC == Questions [i].CorrectAnswer) {
					GameControl.control.CCorrectAnswer = true;
					GameControl.control.isCCorrect = true;
					//WrongSoundAS.clip = WrongSoundAC;
					//WrongSoundAS.Play ();
				} else {
					GameControl.control.CWrongAnswer = true;
					GameControl.control.isCCorrect = false;
				}

				if (Questions [i].OptionD == Questions [i].CorrectAnswer) {
					GameControl.control.DCorrectAnswer = true;
					GameControl.control.isDCorrect = true;
					//WrongSoundAS.clip = WrongSoundAC;
					//WrongSoundAS.Play ();
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
