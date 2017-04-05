using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using com.microeyes.admob;
public class DisplayClass_ComputerBasics : MonoBehaviour {
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

		Questions.Add (new QuestionTemplate (0,"Who invented the computer ?","Stephen Hawking","Charles Babbage","David Warren","Jan Koum","Charles Babbage"));
		Questions.Add (new QuestionTemplate (1,"What are the magic words in keyboard?","AB","fj","QU","PQ","QU"));
		Questions.Add (new QuestionTemplate (2,"What are the Name that we cant create foldername on computer?","computer","com1","com2","com3","com1"));
		Questions.Add (new QuestionTemplate (3,"What are the Name that we cant create foldername on computer?","computer","con","com2","com3","con"));
		Questions.Add (new QuestionTemplate (4,"What are the Name that we cant create foldername on computer?","computer","prn","com2","com3","prn"));
		Questions.Add (new QuestionTemplate (5,"What are the Name that we cant create foldername on computer?","computer","nul","com2","com3","nul"));
		Questions.Add (new QuestionTemplate (6,"What is the full form of DOS?","Disk Operating System","Data Operating System","Digital Operating System ","Diskcopy Operating System","Disk Operating System"));
		Questions.Add (new QuestionTemplate (7,"What is the Shortcut for Mycomputer ?","win+E","win+f","win+z","win+a","win+E"));
		Questions.Add (new QuestionTemplate (8,"Who invented facebook?","Mark Zuckerberg","Jan Koum","Jack Dorsey","Sergey Brin","Mark Zuckerberg"));
		Questions.Add (new QuestionTemplate (9,"Who invented WhatsApp?","Mark Zuckerberg","Jan Koum"," Jack Dorsey","Sergey Brin","Jan Koum"));
		Questions.Add (new QuestionTemplate (10,"Who invented Twitter ?","Mark Zuckerberg","Jan Koum","Jack Dorsey","Sergey Brin","Jack Dorsey"));
		Questions.Add (new QuestionTemplate (11,"Google was founded by?","Mark Zuckerberg","Jan Koum","Jack Dorsey","Sergey Brin","Sergey Brin"));
		Questions.Add (new QuestionTemplate (12,"Who invented the internet?","Mark Zuckerberg","Vint Cerf","Jack Dorsey","Sergey Brin","Vint Cerf"));
		Questions.Add (new QuestionTemplate (13,"Who invented the computer keyboard?","Christopher Latham Sholes","Charles Babbage","Jack Dorsey","Jan Koum","Christopher Latham Sholes"));
		Questions.Add (new QuestionTemplate (14,"What is the Full Form of  RAM ?","Read Only Memory","Random Access Memory","Read Access Memory","Read Array Memory","Random Access Memory"));
		Questions.Add (new QuestionTemplate (15,"What is the Full Form of  ROM ?","Read Only Memory","Random Operating Memory","Read Operatingsystem Memory","Read Array Memory","Read Only Memory"));
		Questions.Add (new QuestionTemplate (16,"What is the Full Form of  COMPUTER?","Commonly Operating Machine particularly Used In Educational Research","Common Operating Machine particularly Used In Educational Research","Compact Operating Machine particularly Used In Educational Research","Complementary Operating Machine particularly Used In Educational Research ","Commonly Operating Machine particularly Used In Educational Research"));
		Questions.Add (new QuestionTemplate (17,"What is the Full Form of  BIOS?"," Basic Input Output System"," Basic Index Operating System","Barrel Input Output System","None"," Basic Input Output System"));
		Questions.Add (new QuestionTemplate (18,"What is the Full Form of  DVD?","Digital Video Disk","Digital Versatile Disc","Digital Video Data","None","Digital Versatile Disc"));
		Questions.Add (new QuestionTemplate (19,"What is the Full Form of  Kbps?"," Kilobits Per Second"," KiloBytes per second","Kilobit Per Second","None"," Kilobits Per Second"));
		Questions.Add (new QuestionTemplate (20,"What is the Full Form of  MOUSE?","Manually Operating system Utility Use For Selecting Equipments","Manually Operated Utility Use For Selecting Equipments"," Machine Operated Utility Use For Selecting Equipments","None","Manually Operated Utility Use For Selecting Equipments"));
		Questions.Add (new QuestionTemplate (21,"What is the Full Form of VIRUS?","Veryfast Information Resources Under Seize","Vital Information Resources Under Seize","Virtual Information Resources Under Seize","None","Vital Information Resources Under Seize"));
		Questions.Add (new QuestionTemplate (22,"The brain of any computer system is?","ALU","Memory","CPU","Control unit","CPU"));
		Questions.Add (new QuestionTemplate (23,"Which of the following computer language is used for Artificial Intelligence?","FORTRAN","PROLOG","C","COBOL","PROLOG"));
		Questions.Add (new QuestionTemplate (24,"Bug means?","A logical error in a program","A difficult syntax error in a program","Documenting programs using an efficient documentation tool","VIRUS","A logical error in a program"));
		Questions.Add (new QuestionTemplate (25,"Who is the creator of the PASCAL language??","Niklaus Writh","Dijkstra","Donald Knuth","Basic Pascal","Niklaus Writh"));
		Questions.Add (new QuestionTemplate (26,"1024 bytes represent a?","Megabyte","Gigabyte","Kilobyte","None of the above","Kilobyte"));
		Questions.Add (new QuestionTemplate (27,"A memory space used for the temporary storage of data is?","PROM","SAM","Scratchpad storage","Buffer","Scratchpad storage"));
		Questions.Add (new QuestionTemplate (28,"The function of CPU is?","To provide a hard copy","To read, interpret and process the information and instruction","To provide external storage of text","To communicate with the operator","To read, interpret and process the information and instruction"));
		Questions.Add (new QuestionTemplate (29,"The term gigabyte refers to?","1024 bytes","1024 kilobytes","1024 megabytes","1024 gigabytes","1024 megabytes"));
		Questions.Add (new QuestionTemplate (30,"Which of the following is not an output device of a computer?","Printer","keyboard","VDU","CRT screen","keyboard"));
		Questions.Add (new QuestionTemplate (31,"The monitor of a computer is connected to it by a?","Modem","Cable","Bus","Line driver","Cable"));
		Questions.Add (new QuestionTemplate (32,"A computer programmer?","does all the thinking for a computer","can enter input data quickly","can operate all types of computer equipment","can draw only flowchart","does all the thinking for a computer"));
		Questions.Add (new QuestionTemplate (33,"Hard disks and diskettes are:?","Direct access storage devices","Sequential access storage devices","Rarely used with microcomputers","None","Direct access storage devices"));
		Questions.Add (new QuestionTemplate (34,"How many bits can be stored in the 8K RAM?","8000","8192","4000","4096","8192"));
		Questions.Add (new QuestionTemplate (35,"Point out the odd item amongst the following?","Computer mouse","Touchpad","Light pen","Printer","Printer"));
		Questions.Add (new QuestionTemplate (36,"A CPU's processing power is measured in?","IPS","CIPS","MIPS","nano-seconds","MIPS"));
		Questions.Add (new QuestionTemplate (37,"A half byte is know is?","Data","Bit","Half byte","Nibble","Nibble"));
		Questions.Add (new QuestionTemplate (38,"One nibble is equal to?","4 bits","8 bits","6 bits","16 bits","4 bits"));
		Questions.Add (new QuestionTemplate (39,"What type of keys are Ctrl and Shift ?","Adjustement","Function","Modifier","Alphanumeric","Modifier"));
		Questions.Add (new QuestionTemplate (40,"Full Form of FAX ?","Far away Xerox","Fast Array Xeox","Fast Accessing Xerox","Fast Add Xerox","Fast Add Xerox"));
		Questions.Add (new QuestionTemplate (41,"Full Form of MB ?","Megabyte","Megabit","Megabits","Megabytes","Megabyte"));
		Questions.Add (new QuestionTemplate (42,"Full Form of WI-FI ?","Wireless Fibers","Wireless Network","Wireless Fiber","Wireless Fidelity","Wireless Fidelity"));
		Questions.Add (new QuestionTemplate (43,"8 Bits = ?","1GB","1 KB","1 Byte","1 MB","1 Byte"));
		Questions.Add (new QuestionTemplate (44,"1024 Bytes = ?","1GB","1 KB","1 Byte","1 MB","1 KB"));
		Questions.Add (new QuestionTemplate (45,"1024 KB = ?","1GB","1 KB","1 Byte","1 MB","1 MB"));
		Questions.Add (new QuestionTemplate (46,"1024 MB = ?","1 GB","1 KB","1 Byte","1 MB","1 GB"));
		Questions.Add (new QuestionTemplate (47,"1024 GB = ?","10 GB","1 KB","1 Byte","1 TB","1 TB"));
		Questions.Add (new QuestionTemplate (48,"1024 TB = ?","1GB","1 PB","1 YB","1 MB","1 PB"));
		Questions.Add (new QuestionTemplate (49,"1024 PB = ?","100 GB","1 EB","1 ZB","1 MB","1 EB"));
		Questions.Add (new QuestionTemplate (50,"1024 EB = ?","100 GB","1 KB","1 Byte","1 ZB","1 ZB"));
		Questions.Add (new QuestionTemplate (51,"1024 ZB = ?","1 YB","10 KB","1 Byte","1 MB","1 YB"));
		Questions.Add (new QuestionTemplate (52,"1024 YB = ?","1000 GB","1 KB","1 GeopByte","1 MB","1 GeopByte"));
		Questions.Add (new QuestionTemplate (53,"1024 Bronto Byte = ?","1 GeopByte","1 KB","1 Byte","1 MB","1 GeopByte"));
		Questions.Add (new QuestionTemplate (54,"An Enhanced Graphics Adopter(EGA) display has a resolution of = ?","640*350","640*1024","640*680","640*300","640*350"));
		Questions.Add (new QuestionTemplate (55,"What is the Decahertz(daHz) Frequency in Exponent Form = ?","10¹","10²","10³","10½","10¹"));
		Questions.Add (new QuestionTemplate (56," What is the Hectohertz(hHz) Frequency in Exponent Form = ?"," 10¹","10³","10²","10½","10²"));
		Questions.Add (new QuestionTemplate (57," What is the Kilohertz(kHz) = ?"," 10¹","10½","10³","10²","10³"));
		Questions.Add (new QuestionTemplate (58," What is the Megahertz (MHz)= ?"," 10¹","1012","1024","106","106"));
		Questions.Add (new QuestionTemplate (59," What is the Gegahertz (GHz)= ?"," 10¹","109to1012","10³to1012","10²","109to1012"));
		Questions.Add (new QuestionTemplate (60," What is the Terahertz (THz)= ?"," 10¹","1012to1015","10³","10²","1012to1015"));
		Questions.Add (new QuestionTemplate (61," What is the Petahertz (PHz)= ?"," 10¹","106","1012","1015","1015"));
		Questions.Add (new QuestionTemplate (62," What is the Exahertz (EHz)= ?"," 10¹","106","1018","1015","1018"));
		Questions.Add (new QuestionTemplate (63," What is the Zetahertz (ZHz)= ?"," 10¹","1012","10³","1021","1021"));
		Questions.Add (new QuestionTemplate (64," What is the Yotahertz(YHz) = ?"," 106","1024","10³","1021","1024"));

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
