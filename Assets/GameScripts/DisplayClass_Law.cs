using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using com.microeyes.admob;
public class DisplayClass_Law : MonoBehaviour {

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

		Questions.Add (new QuestionTemplate (0," Finance Commission of India submits its report to— ?"," Chief justice of India"," Prime Minister"," Vice President"," President of India"," President of India"));
		Questions.Add (new QuestionTemplate (1," What is the nature of Finance Commission—?"," Advisory"," Binding"," Appellate"," Executive"," Advisory"));
		Questions.Add (new QuestionTemplate (2," What kind of body is Election Commission—?"," Permanent and independent body"," Permanently dependent on Executive"," Independent body"," Depends on Parliament"," Permanent and independent body"));
		Questions.Add (new QuestionTemplate (3," Why Election Commission is an all India Body as it is -?","Common to both central and state Govt"," Common for more than one state"," Only for Central Govt"," Only for State Govt","Common to both central and state Govt"));
		Questions.Add (new QuestionTemplate (4," Chief Election Commissioner is entitled to same salary & facilities as are provided to —?"," Judge of HC "," Member Parliament "," Member of Legislative Assembly "," Judge of SC "," Judge of SC "));
		Questions.Add (new QuestionTemplate (5," Chief Election Commissioner is appointed by—?"," Prime Minister "," Parliament "," President "," Vice President "," President "));
		Questions.Add (new QuestionTemplate (6," The word Socialist was added by the________ Constitutional Amendment—?"," 44 th "," 42nd "," 25th "," 24th "," 42nd "));
		Questions.Add (new QuestionTemplate (7," Consolidated Fund of India and States is mentioned in which Article of the Constitution?"," Art 215 "," Art 234 "," Art 226 "," Art 227 "," Art 226 "));
		Questions.Add (new QuestionTemplate (8," The Railway Budget was separated from the General Budget in the year—?"," 1925 "," 1923 "," 1921 "," 1924 "," 1924 "));
		Questions.Add (new QuestionTemplate (9," The Indian Federal system is modeled on the federal system of—?"," USA "," UK "," Canada "," France "," Canada "));
		Questions.Add (new QuestionTemplate (10," The Government of India can borrow from outside on the security of its consolidated fund, it is mentioned in — -?"," Art 233 "," Art 294 "," Art 287 "," Art 292 "," Art 292 "));
		Questions.Add (new QuestionTemplate (11," Which Court is regarded as the Guardian of the Fundamental Rights of the people— ?"," Privy Council "," Federal Court "," Supreme Court "," High Court "," Supreme Court "));
		Questions.Add (new QuestionTemplate (12," Right to Property is a legal Right mentioned in which Article of the Indian Constitution—?"," 330A "," 332 "," 339 A "," 230 D "," 330A "));
		Questions.Add (new QuestionTemplate (13," Emergency Provisions of Constitution of India are borrowed from—?"," German Reich "," USA "," USSR "," UK "," German Reich "));
		Questions.Add (new QuestionTemplate (14," Presidential Form of Government has been borrowed from—?"," USA "," USSR "," UK "," France "," USA "));
		Questions.Add (new QuestionTemplate (15," Directive Principles of state Policy are taken from—?"," UK Constitution "," French Constitution "," USSR constitution "," Irish Constitution "," Irish Constitution "));
		Questions.Add (new QuestionTemplate (16," Which Regulating Act introduced the process of Centralisation—?"," Regulation Act 1617 "," Regulating Act 1773 "," Regulating Act 1569 "," Regulating Act 1680 "," Regulating Act 1773 "));
		Questions.Add (new QuestionTemplate (17," The First Indian High Courts Act came into existence in -?"," 1867 "," 1861 "," 1864 "," 1865 "," 1861 "));
		Questions.Add (new QuestionTemplate (18,"When was the Advocates Act came into existence—?"," 1962 "," 1963 "," 1961 "," 1968 "," 1961 "));
		Questions.Add (new QuestionTemplate (19," Name the newly created democracy of the world?"," Nepal "," Bhutan "," Myanmar "," Bangladesh "," Bhutan "));
		Questions.Add (new QuestionTemplate (20," Who has been conferred King Charles II Medal by Royal Society for his contribution to the promotion of science and science in society in India -?"," Pratibha Patel "," Manmohan Singh "," Sonia Gandhi "," APJ Abdul Kalam "," APJ Abdul Kalam "));
		Questions.Add (new QuestionTemplate (21," Which act empowered the Governor-General to alter the local limits of the jurisdiction of the HC -?"," High Courts Act 1864 "," High Courts Act 1856 "," High Courts Act 1865 "," High Courts Act 1863 "," High Courts Act 1865 "));
		Questions.Add (new QuestionTemplate (22," Which Indian State was the first to be formed on Linguistic basis—?"," Arunanchal Pradesh "," Haryana "," Punjab "," Andhra Pradesh "," Andhra Pradesh "));
		Questions.Add (new QuestionTemplate (23," Andhra Pradesh was created by taking Telugu speaking areas of -?"," Madras, Kerala, Bombay "," Kerala, Bombay, Gujrat "," Gujrat, Central Province, Kerala, Madras "," Madras, Bombay, Central Province "," Madras, Bombay, Central Province "));
		Questions.Add (new QuestionTemplate (24," When was Pondicherry handed over by French to India and added as UT -?"," 1956 "," 1923 "," 1954 "," 1955 "," 1954 "));
		Questions.Add (new QuestionTemplate (25," The quorum for meetings of the House of People constitutes—?"," 1/10th of the total members "," 1/10th of the total members or 100 members whichever is less "," 1/3rd of the total number "," 100 members "," 1/10th of the total members "));
		Questions.Add (new QuestionTemplate (26," In which case, the Supreme Court directed the Government to implement the law against female feticides with full determination? ?"," Parents Association Vs. Union of India "," Madhu Kishwar V. State of Bihar "," CEHAT Vs. Union of India "," Nishi Maghu Vs. State of Jammu and Kashmir "," CEHAT Vs. Union of India "));
		Questions.Add (new QuestionTemplate (27," Assertion (A) : Right to education is a Fundamental Right.Reason (R) : Our Constitution has no provision for education before making right to education as Fundamental Right.Codes:?"," Both (A) and (R) are true and (R) is the correct explanation of (A) "," Both (A) and (R) are true and (R) is not a correct explanation of (A) "," (A) is true but (R) is falser "," (A) is false but (R) is true "," (A) is true but (R) is falser "));
		Questions.Add (new QuestionTemplate (28," The law declared by Supreme Court of India is binding on all courts within the territory of India, but the Supreme Court is not bound by its decision was decided by the Supreme Court itself in—?"," Keshavanand Bharati Vs. State of Kerala "," Indira Nehru Gandhi Vs. Raj Narain "," Madhav Rao Scindia Vs. Union of India "," Bengal Immunity Co. Ltd. Vs. State of Bihar "," Bengal Immunity Co. Ltd. Vs. State of Bihar "));
		Questions.Add (new QuestionTemplate (29," The statement in order to constitute a ‘confession’ under the Indian Evidence Act, must either admit in terms the offence or at any rate substantially all facts which constitute the offence. The above view was expressed by the Privy Council in which one of the following cases??"," John Makin Vs. Attorney General "," Pakla Narain Swamy Vs. Emperor "," H.H.B. Gill Vs. King Emperor "," Q. E. Vs. Abdullah "," Pakla Narain Swamy Vs. Emperor "));
		Questions.Add (new QuestionTemplate (30," In which of the following cams, it was held that Section-27 of the Indian Evidence Act, 1872 is an exception to Sections-24, 25 and 26?"," Pakla Narain Swamy Vs. King Emperor "," Inayatullah Vs. State of Maharashtra "," State of U.P. Vs. Deoman Upadhyaya "," P. Kottayya Vs. King Emperor "," P. Kottayya Vs. King Emperor "));
		Questions.Add (new QuestionTemplate (31," In a pledge ownership of property or goods?"," Continued in pledge "," Transferred to the pledge "," Cannot be transferred to pledges under any circumstances "," Cannot continue with pledge under any circumstances "," Continued in pledge "));
		Questions.Add (new QuestionTemplate (32," If the holder of service land dies, resigns or is lawfully dismissed, the land shall pass—?"," By survivorship "," To his successor -in-office "," By agreement "," By patta "," To his successor -in-office "));
		Questions.Add (new QuestionTemplate (33," Agriculture year means the year commencing on—?"," 1st day of January "," 1st day of April "," 1st day of July "," 1st day of October "," 1st day of July "));
		Questions.Add (new QuestionTemplate (34," Under section 50 of M.P. Land Revenue Code, no application for revision shall be entertained by Commissioner or Settlement Commissioner or Collector or Settlement Officer, as the case may be, unless presented within—?"," Thirty days"," Forty-five days"," Sixty days"," Seventy-five days from the date of order"," Sixty days"));
		Questions.Add (new QuestionTemplate (35," On his death, interest of Bhumiswami shall not pass by—?"," Inheritance"," Survivorship"," Bequest"," Any agreement"," Any agreement"));
		Questions.Add (new QuestionTemplate (36," Where a dispute arises between the State Government and any person in respect of any right under section 57(1) of M.P. Land Revenue Code, providing for State ownership in all lands, such dispute shall be decided by the—?"," Revenue Board"," Patwari"," Sub-Divisional Officer"," Naib Tehsildar"," Sub-Divisional Officer"));
		Questions.Add (new QuestionTemplate (37," Any person aggrieved by any entry made in Wazib-ul-arj may institute a suit in Civil Court to have such entry cancelled or modified within?"," 90 days"," One year"," Two years"," Three years"," One year"));
		Questions.Add (new QuestionTemplate (38," A decree may be executed ?"," By the court which passed the decree"," By any other court to which a decree has been sent for execution"," Both statements are correct"," Both statements are incorrect"," Both statements are correct"));
		Questions.Add (new QuestionTemplate (39," A decree can be—?"," Preliminary"," Final"," First preliminary then final"," Either preliminary or final"," Either preliminary or final"));
		Questions.Add (new QuestionTemplate (40," Principle of Resjudicata applies—?"," To suits only"," To execution proceedings only"," To arbitration proceedings only"," To suits as well as execution proceedings"," To suits as well as execution proceedings"));
		Questions.Add (new QuestionTemplate (41," The plaint shall be rejected by the court, under order 7 rule 11(e) of Civil Procedure Code, if it is not filed in— ?"," Duplicate"," Triplicate"," Quadruplicate"," Five copies"," Duplicate"));
		Questions.Add (new QuestionTemplate (42," An ex prate decree can be set aside on the ground that—?"," Summons were not duly served"," Non-appearance of defendant as copies of documents filed with plaint were not provided to defendant"," Defendant refused to receive the summons and thereafter no fresh summons were issued to him"," An ex prate decree cannot be set aside under any circumstance"," Summons were not duly served"));
		Questions.Add (new QuestionTemplate (43," Pleading can be amended—?"," Before the trial court only"," Before either the trial court or first appellate court or second appellate court"," Before second appellate court only"," Before the first appellate court only"," Before either the trial court or first appellate court or second appellate court"));
		Questions.Add (new QuestionTemplate (44,"  A judgment passed by a court can be reviewed by—?"," The court passing the judgement"," The court of District Judge"," The High Court"," The Supreme Court"," The court passing the judgement"));
		Questions.Add (new QuestionTemplate (45," X finds one thousand rupee’s note on the public road. He does not know to whom the note belongs. X pick up the note. Here X has—?"," Not committed any offence"," Committed dishonest mis-appropriation of property"," Committed robbery"," Committed theft"," Not committed any offence"));
		Questions.Add (new QuestionTemplate (46," X and Y both go to murder Z, X stood on guard with a spear in hand but did not hit Z at all Y killed?"," Only Y is liable for murder of Z"," X and Y both are liable for murder of Z"," X is not liable as he did not perform any overt act"," (A) and (C) both are correct"," X and Y both are liable for murder of Z"));
		Questions.Add (new QuestionTemplate (47," X is at work with hatchet, the head of hatchet flies off and kills a man Y who was stand by Here, if there is no want of proper Caution on the part of X, his act is—?"," Not excusable and an offence"," Excusable and not an offence"," An offence but benefit of probation is necessary"," An offence or not is depend of the sweet will of the legal representative of deceased"," Excusable and not an offence"));

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
