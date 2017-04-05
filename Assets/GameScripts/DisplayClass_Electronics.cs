using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using com.microeyes.admob;
public class DisplayClass_Electronics : MonoBehaviour {

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

		Questions.Add (new QuestionTemplate (0," To prevent a DC return between source and load, it is necessary to use?"," resistor between source and load","inductor between source and load","capacitor between source and load","either (a) or (b)","capacitor between source and load"));
		Questions.Add (new QuestionTemplate (1," For a base current of 10 μA, what is the value of collector current in common emitter if βdc = 100?"," 10 μA","100 μA","1 mA","10 mA","1 mA"));
		Questions.Add (new QuestionTemplate (2," Which of the following oscillators is suitable for frequencies in the range of mega hertz??"," RC phase shift"," Wien bridge"," Hartley"," Both (a) and (c)"," Hartley"));
		Questions.Add (new QuestionTemplate (3," The open loop gain of an amplifier is 200. If negative feedback with β = 0.2 is used, the closed loop gain will be?"," 200"," 40.12"," 4.878"," 2.2"," 4.878"));
		Questions.Add (new QuestionTemplate (4," In a class C power amplifier the input signal has a frequency of 250 kHz. If the collector current pulses are 0.1 μs wide, the duty cycle of current waveform is?"," 50%"," 25%"," 2.5%"," 0.25%"," 2.5%"));
		Questions.Add (new QuestionTemplate (5," A 12 kHz pulse wave-form is amplified by a circuit having an Upper cut-off frequency of 1 MHz. The minimum input pulse width that can be accurately reproduced is?"," 83.33 μ sec "," 1 μ sec "," 0.1 m sec "," 3.5 m sec "," 1 μ sec "));
		Questions.Add (new QuestionTemplate (6," An RC oscillator uses?","One RC combination","Two RC combinations","At least three RC combinations"," Either (a) or (b) ","At least three RC combinations"));
		Questions.Add (new QuestionTemplate (7," The main advantage of CMOS circuit is?"," high gain "," high output impedance "," low power consumption "," high gain and high output impedance "," low power consumption "));
		Questions.Add (new QuestionTemplate (8," Ac signals are given to both inverting and non-inverting terminals of an op-amp. When will the output maximum?"," when the phase difference between the inputs is 0°"," when the phase difference between the inputs in 90°"," when the phase difference between the inputs is 180°"," when the phase difference between the inputs is 0 or 180°"," when the phase difference between the inputs is 180°"));
		Questions.Add (new QuestionTemplate (9," In a bridge rectifier circuit the rms value of input ac voltage is 10 V. The PIV across each diode is?"," 7.07 V"," 14.14 V"," 10 V"," 28.28 V"," 14.14 V"));
		Questions.Add (new QuestionTemplate (10," In a half wave diode rectifier circuit the current flows in the load circuit for?"," 90° in each cycle"," 180° in each cycle"," 270° in each cycle"," 360° in each cycle"," 180° in each cycle"));
		Questions.Add (new QuestionTemplate (11," In a push pull circuit?"," each transistor conducts for 180° "," each transistor conducts for more than 180° but less than 360°"," each transistor conducts for less than 180°"," the period of conduction of each transistor depends on circuit configuration"," each transistor conducts for 180° "));
		Questions.Add (new QuestionTemplate (12," The input voltage for starting oscillations in an oscillator is caused by?"," negative feedback"," positive feedback"," noise voltage in resistors"," a special generator"," noise voltage in resistors"));
		Questions.Add (new QuestionTemplate (13," The current flowing in a certain P-N junction at room temperature is 2 x 10-7 Amp. When a large reverse biased voltage is applied. Calculate the current flowing when 0.1 volts is applied.?"," 9 μA"," 10 μA"," 2 μA"," 4 μA"," 9 μA"));
		Questions.Add (new QuestionTemplate (14," Which of the following power amplifiers has highest efficiency?"," Class A"," Class AB"," Class B"," Class C"," Class C"));
		Questions.Add (new QuestionTemplate (15," An op-amp has zero gain for common mode inputs. Then CMRR =?"," zero"," infinite"," high"," low"," infinite"));
		Questions.Add (new QuestionTemplate (16," In an amplifier the voltage gain is the ratio of ?"," output voltage and emitter resistance"," output voltage and input current"," output voltage and input voltage"," none of the above"," output voltage and input voltage"));
		Questions.Add (new QuestionTemplate (17," The dissipation at the collector is in the quiescent state and increases with excitation in the case of a ?"," class A series fed Amplifier"," class A transistor coupled Amplifier"," class AB amplifier"," class B amplifier"," class B amplifier"));
		Questions.Add (new QuestionTemplate (18," The open loop gain of an ideal op-amp is?"," infinite"," very high"," neither high nor low"," low"," infinite"));
		Questions.Add (new QuestionTemplate (19," The ideal characteristics of a stabilizer is ?"," constant output voltage with low internal resistance"," constant output current with low internal resistance"," constant output voltage with high internal resistance"," constant internal resistance and constant output current"," constant output voltage with low internal resistance"));
		Questions.Add (new QuestionTemplate (20," In a CE amplifier drives a low load resistance directly the result will be ?"," overloading of amplifier"," underloading of amplifier"," overloading or underloading of amplifier depending on circuit"," none of the above"," overloading of amplifier"));
		Questions.Add (new QuestionTemplate (21," For high frequencies a capacitor like?"," an open circuit"," a short circuit"," either open circuit or short circuit"," none of the above"," a short circuit"));
		Questions.Add (new QuestionTemplate (22," The coupling capacitor in amplifier circuits?"," affects dc biasing"," does not affect dc biasing"," affects dc biasing to some extent"," both (a) and (c)"," does not affect dc biasing"));
		Questions.Add (new QuestionTemplate (23," The open loop gain of an amplifier is 200. If negative feedback with β = 0.2 is used, the closed loop gain will be ?"," 200"," 40.12"," 4.878"," 2.2"," 4.878"));
		Questions.Add (new QuestionTemplate (24," In a class C power amplifier the input signal has a frequency of 250 kHz. If the collector current pulses are 0.1 μs wide, the duty cycle of current waveform is ?"," 50%"," 25%"," 2.5%"," 0.25%"," 2.5%"));
		Questions.Add (new QuestionTemplate (25," In a push pull circuit ?"," each transistor conducts for 180° "," each transistor conducts for more than 180° but less than 360° "," each transistor conducts for less than 180° "," the period of conduction of each transistor depends on circuit configuration "," each transistor conducts for 180° "));
		Questions.Add (new QuestionTemplate (26," In a half wave diode rectifier circuit the current flows in the load circuit for ?"," 90° in each cycle "," 180° in each cycle "," 270° in each cycle "," 360° in each cycle "," 180° in each cycle "));
		Questions.Add (new QuestionTemplate (27," In a bridge rectifier circuit the rms value of input ac voltage is 10 V. The PIV across each diode is ?"," 7.07 V "," 14.14 V "," 10 V "," 28.28 V "," 14.14 V "));
		Questions.Add (new QuestionTemplate (28," An RC oscillator uses ?","One RC combination","Two RC combinations","At least three RC combinations","None","At least three RC combinations"));
		Questions.Add (new QuestionTemplate (29," The main advantage of CMOS circuit is ?"," high gain "," high output impedance "," low power consumption "," high gain and high output impedance "," low power consumption "));
		Questions.Add (new QuestionTemplate (30," Ac signals are given to both inverting and non-inverting terminals of an op-amp. When will the output maximum ?"," when the phase difference between the inputs is 0° "," when the phase difference between the inputs in 90° "," when the phase difference between the inputs is 0 or 180° "," when the phase difference between the inputs is 180° "," when the phase difference between the inputs is 180° "));
		Questions.Add (new QuestionTemplate (31," The input voltage for starting oscillations in an oscillator is caused by ?"," negative feedback"," positive feedback"," noise voltage in resistors"," a special generator"," noise voltage in resistors"));


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
