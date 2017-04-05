using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using com.microeyes.admob;
public class DisplayClass_ControlSystems : MonoBehaviour {

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

		Questions.Add (new QuestionTemplate (0,"What is the color of SUN ?","Orange","Yellow","Red","White","White"));
		Questions.Add (new QuestionTemplate (1,"How Many Moons Does Mars Have ?","4","2","3","1","2"));
		Questions.Add (new QuestionTemplate (2,"Which is the longest tower of the world ?","Burj khalifa","Shanghai Tower","CN Tower","CTF Finance Centre","CN Tower"));
		Questions.Add (new QuestionTemplate (3,"Which planet has the lowest density ?","Saturn","Mercury","Venus","Uranus","Saturn"));
		Questions.Add (new QuestionTemplate (4,"Capital of maldives ?","Villingili","Malé","Gan","Maradhoo","Malé"));
		Questions.Add (new QuestionTemplate (5,"Which is the Hottest Planet in the Solar System ?","Mercury","Venus","Jupiter","Mars","Venus"));
		Questions.Add (new QuestionTemplate (6,"Which is largest star ?","VVcephei","Rigel","VYcanis majoris","MUcephei","VYcanis majoris"));
		Questions.Add (new QuestionTemplate (7,"Which is the largest planetary moon ?","Titan","Callisto","Lo","Ganymede","Ganymede"));
		Questions.Add (new QuestionTemplate (8,"Which is the deepest ocean of the world?","Pacific ocean","Southern ocean","Atlantic ocean","Indian ocean","Southern ocean"));
		Questions.Add (new QuestionTemplate (9,"Which is the largest country in Asia ?","Russia","Canada","Algeria","China","China"));
		Questions.Add (new QuestionTemplate (10,"Which country is called as the sugar bowl of the world ?","Cuba","Netherlands","Norway","Sweden","Cuba"));
		Questions.Add (new QuestionTemplate (11,"Which country used the largest armed forces in the world war I ?","USA","Germany","France", "Russia","Russia"));
		Questions.Add (new QuestionTemplate (12,"Which language is most spoken in world?","Arabic","Spanish","English","Chinese","Chinese"));
		Questions.Add (new QuestionTemplate (13,"Which is the fastest bird of the world ?","Common Eider","Mallard","Wood pigeon","Grey-headed albatross","Grey-headed albatross"));
		Questions.Add (new QuestionTemplate (14,"Which is the most produced metal in the world ?","Iron","Chromium","Steel","Zinc","Steel"));
		Questions.Add (new QuestionTemplate (15,"Which is the highest oil producing country ?","Saudi arabia","Iran","Russia","USA","Russia"));
		Questions.Add (new QuestionTemplate (16,"Which country has hosted the most F1 championship races ?","Italy","UK","Germany","Brazil","Italy"));
		Questions.Add (new QuestionTemplate (17,"Which is the most valuable global brand ?","Google","Apple","Coca-Cola","Microsoft","Coca-Cola"));
		Questions.Add (new QuestionTemplate (18,"Which country has the largest buddhist population ?","Japan","China","India","Sri lanka","China"));
		Questions.Add (new QuestionTemplate (19,"In which year did the first animal launced into the space ?","1953","1957","1959","1963","1957"));
		Questions.Add (new QuestionTemplate (20,"Which is the highest waterfall of the world ?","Wailhilau","Mongefossen","Olmafossen","Angel","Angel"));
		Questions.Add (new QuestionTemplate (21,"Which of the following is a non metal that remains liquid at room temperature?","Phosphorous","Bromine","Chlorine","Helium","Bromine"));
		Questions.Add (new QuestionTemplate (22,"Which of the following is used in pencils?","Graphite","Silicon","Charcoal","Phosphorous","Graphite"));
		Questions.Add (new QuestionTemplate (23,"Which of the following metals forms an amalgam with other metals?","Tin","Mercury","Lead","Zinc","Mercury"));
		Questions.Add (new QuestionTemplate (24,"Chemical formula for water is","NaAlO2","H2O","Al2O3","CaSiO3","H2O"));
		Questions.Add (new QuestionTemplate (25,"The gas usually filled in the electric bulb is","Nitrogen","Hydrogen","Carbon dioxide","Oxygen","Nitrogen"));
		Questions.Add (new QuestionTemplate (26,"Washing soda is the common name for","Sodium carbonate","Calcium bicarbonate","Sodium bicarbonate","Calcium carbonate","Sodium carbonate"));
		Questions.Add (new QuestionTemplate (27,"Which of the gas is not known as green house gas?","Methane","Nitrous oxide","Carbon dioxide","Hydrogen","Hydrogen"));
		Questions.Add (new QuestionTemplate (28,"The hardest substance available on earth is","Gold","Iron","Diamond","Platinum","Diamond"));
		Questions.Add (new QuestionTemplate (29,"Which of the following is used as a lubricant?","Graphite","Silica","Iron Oxide","Diamond","Graphite"));
		Questions.Add (new QuestionTemplate (30,"The average salinity of sea water is","3%","3.5%","2.5%","2%","3.5%"));
		Questions.Add (new QuestionTemplate (31,"Decibel is the unit for","Speed of light","Radio wave frequency","Intensity of sound","Intensity of heat","Intensity of sound"));
		Questions.Add (new QuestionTemplate (32,"One fathom is equal to","6 feet","6 meters","60 feet","100 cm","6 feet"));
		Questions.Add (new QuestionTemplate (33,"Light year is a measurement of","Speed of aeroplanes","Speed of light","Stellar distances","Speed of rockets","Stellar distances"));
		Questions.Add (new QuestionTemplate (34,"One kilometre is equal to how many miles?","0.84","0.5","1.6","0.62","0.62"));
		Questions.Add (new QuestionTemplate (35,"One horse power is equal to","746 watts","748 watts","756 watts","736 watts","746 watts"));
		Questions.Add (new QuestionTemplate (36,"Kilowatt is a unit to measure","Work","Power","Electricity","Current","Power"));
		Questions.Add (new QuestionTemplate (37,"Electric current is measure by","Commutator","Anemometer","Ammeter","Voltmeter","Ammeter"));
		Questions.Add (new QuestionTemplate (38,"A chronometer measures","Colour contrast","Sound waves","Time","Water waves","Time"));
		Questions.Add (new QuestionTemplate (39,"Atoms are composed of","Electrons and protons","Electrons only","Protons only","Electrons and nuclei","Electrons and nuclei"));
		Questions.Add (new QuestionTemplate (40,"Mesons are found in","Laser beam","X-rays","Gamma rays","Cosmic rays","Cosmic rays"));
		Questions.Add (new QuestionTemplate (41,"The age of most ancient geological formations is estimated by","Ra - Si method","Potassium - argon method","C14 method","Uranium - lead method","C14 method"));
		Questions.Add (new QuestionTemplate (42,"Who suggested that most of the mass of the atom is located in the nucleus?","Thompson","Bohr","Rutherford","Einstein","Rutherford"));
		Questions.Add (new QuestionTemplate (43,"Which of the following rays are more penetrating?","Beta rays","Alpha rays","Gamma rays","X-rays","Gamma rays"));
		Questions.Add (new QuestionTemplate (44,"How many colours the sunlight spectrum has?","Three","Seven","Four","Five","Seven"));
		Questions.Add (new QuestionTemplate (45,"The great Victoria Desert is located in","Canada","West Africa","Australia","North America","Australia"));
		Questions.Add (new QuestionTemplate (46,"The intersecting lines drawn on maps and globes are","Latitudes","Longitudes","Geographic grids","None of the above","Geographic grids"));
		Questions.Add (new QuestionTemplate (47,"Which of the following is tropical grassland?","Taiga","Savannah","Pampas","Prairies","Savannah"));
		Questions.Add (new QuestionTemplate (48,"The humidity of the air depends upon","Temperature","Location","Weather","All the above","All the above"));
		Questions.Add (new QuestionTemplate (49,"The largest glaciers are","Mountain glaciers","Alpine glaciers","Continental glaciers","Piedmont glaciers","Continental glaciers"));
		Questions.Add (new QuestionTemplate (50,"The ionosphere includes","Mesosphere","Thermosphere","Thermosphere and exosphere","Thermosphere, Exosphere and mesosphere","Thermosphere and exosphere"));
		Questions.Add (new QuestionTemplate (51,"What is Densest element in the world","Iridium","Platinum","Tungsten","Osmium","Osmium"));
		Questions.Add (new QuestionTemplate (52,"Which is the biggest desert in the world ?","Gobi","Thar","Sahara","Kalahari","Sahara"));
		Questions.Add (new QuestionTemplate (53,"Which is the longest river in the world ?","Nile","Amazon","Missipi","Missouri","Nile"));
		Questions.Add (new QuestionTemplate (54,"Which is the smallest bird ?","Humming bird","Sparrow","Jay blue","Scrub jay","Humming bird"));
		Questions.Add (new QuestionTemplate (55,"Which is the first country to give women the right to vote ?","New Zealand","Australia","Finland","Norway","New Zealand"));
		Questions.Add (new QuestionTemplate (56,"Who is the first explorer to reach America?","John Cabot","Vasco da gama","Christopher Columbus","Pinzon","Christopher Columbus"));
		Questions.Add (new QuestionTemplate (57,"Who is the first person to climb Everest?","Tenzing Norgay","Edmund Hillary","Schmied","Dolf Reist","Edmund Hillary"));
		Questions.Add (new QuestionTemplate (58,"Which is the country with most primary pupils ?","India","China","Pakistan","USA","India"));
		Questions.Add (new QuestionTemplate (59,"Which is the country with highest unemployment?","Zimbabwe","Kenya","Zambia","Nepal","Zimbabwe"));
		Questions.Add (new QuestionTemplate (60,"Who is the first man to land on the moon ?","Edward Aldren","Michael Slater","Henry Armstrong","Neil Armstrong","Neil Armstrong"));
		Questions.Add (new QuestionTemplate (61,"Hitler party which came into power in 1933 is known as Party","Nazi Party","Ku-Klux-Klan","Democratic Party","Labour Party","Nazi Party"));
		Questions.Add (new QuestionTemplate (62,"Who is the father of Geometry ?","Aristotle","Euclid","Kepler","Pythagoras","Euclid"));
		Questions.Add (new QuestionTemplate (63,"Which city is called City of SkyScrapers ?","New York","Washington","Las Vegas","Texas","New York"));
		Questions.Add (new QuestionTemplate (64,"Currency of Japan ?","Yen","Yuan","Rupee","Dollar","Yen"));
		Questions.Add (new QuestionTemplate (65,"Currency of China ?","Yen","Yuam","Yuan","Lira","Yuan"));
		Questions.Add (new QuestionTemplate (66,"What was the old name of Taiwan ?","Siam","Ceylon","Formosa","Mesptomia","Formosa"));
		Questions.Add (new QuestionTemplate (67,"What was the old name of Myanmar ?","Burma","Ceylon","Pakistan","India","Burma"));
		Questions.Add (new QuestionTemplate (68,"What is national animal of USA ?","Bald Eagle","Tiger","Panther","Lion","Bald Eagle"));
		Questions.Add (new QuestionTemplate (69,"What is Currency of USA ?","Lira","Dollar","Yuan","Yen","Dollar"));
		Questions.Add (new QuestionTemplate (70,"What planet is closest to Sun?","Venus","Mercury","Mars","Jupiter","Mercury"));
		Questions.Add (new QuestionTemplate (71,"What is bronze ?","Tin+copper","Iron+copper","Copper+zinc ","Iron+zirconium","Tin+copper"));
		Questions.Add (new QuestionTemplate (72,"What is Smallest Ocean?","Arctic Ocean","Pacific Ocean","Indian Ocean","Atlantic Ocean","Arctic Ocean"));
		Questions.Add (new QuestionTemplate (73,"What is Capital of China ?","Beijing","Tokyo","Osaka","Taipei","Beijing"));
		Questions.Add (new QuestionTemplate (74,"What is Capital of India ?","Mumbai","Hyderabad","New Delhi","Chennai","New Delhi"));
		Questions.Add (new QuestionTemplate (75,"What is largest producer of coffee ?","India","Sri lanka","Brazil","Argentina","Brazil"));
		Questions.Add (new QuestionTemplate (76,"What is largest producer of tea ?","India","Sri lanka","Pakistan","Afghanistan","India"));
		Questions.Add (new QuestionTemplate (77,"The moon is a?","Comet","Satellite","Star","Planet","Satellite"));
		Questions.Add (new QuestionTemplate (78,"Capital of Azerbaijan ?","Baku","Tashkent","Dushanbe","Ashgbat","Baku"));
		Questions.Add (new QuestionTemplate (79,"Theory of Copernicus ?","Helio-centric","Geo-centric","Ptolemaic","Law of Orbits","Helio-centric"));
		Questions.Add (new QuestionTemplate (80,"Largest Flower ?","Rafflesia","Lotus","Jasmine","Rose","Rafflesia"));
		Questions.Add (new QuestionTemplate (81,"Largest known star is ?","VY Canis Majoris","Sirius","Pollux","Rigel","VY Canis Majoris"));
		Questions.Add (new QuestionTemplate (82,"Force= ?","Mass * Velocity","Mass * Acceleration","Mass * Time","Mass * Speed","Mass * Acceleration"));
		Questions.Add (new QuestionTemplate (83,"Which of the following is not Einstein's invention ?","Photo-electric effect","Mass-Energy Equivalence","Brownian motion","Cyclotron","Cyclotron"));
		Questions.Add (new QuestionTemplate (84,"Which is the religion practised by most of the African people ?","Hinduism","Islam","Christianity","Judaism","Islam"));
		Questions.Add (new QuestionTemplate (85,"Pope resides where ?","Vatican City","Italy","France","Monaco","Vatican City"));
		Questions.Add (new QuestionTemplate (86,"Tallest Building of the World ?","Abraj Al-Bait Towers","Shanghai Tower","Taipei 101","Burj Khalifa","Burj Khalifa"));
		Questions.Add (new QuestionTemplate (87,"The intensity of Earthquakes is measured on ?","Richter scale","Secant scale","Mercalli scale","Beaufort scale","Richter scale"));
		Questions.Add (new QuestionTemplate (88,"The gas predominantly responsible for global warning is ?","Carbon dioxide","Carbon monoxide","Nitrous oxide","Nitrogen peroxide","Carbon dioxide"));
		Questions.Add (new QuestionTemplate (89,"The blue colour of the clear sky is due to ?"," Diffraction of light","Refraction of light","Dispersion of light","Reflection of light","Dispersion of light"));
		Questions.Add (new QuestionTemplate (90,"Select the one which is not a mixture  ?","Air"," Gasoline","LPG","Distilled water","Distilled water"));
		Questions.Add (new QuestionTemplate (91,"Persons with which blood group are called universal donors ?","AB","O","A","B","O"));
		Questions.Add (new QuestionTemplate (92,"Who gave the first evidence of the Big- Bang theory ?","Edwin Hubble","Albert Einstein","S. Chandrasekhar","Stephen Hawking","Edwin Hubble"));

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
