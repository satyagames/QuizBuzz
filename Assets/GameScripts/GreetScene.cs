using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using com.microeyes.admob;

public class GreetScene : MonoBehaviour {
	public Text GreetText;
	public Text LevelStatus;
	public Text CurrentLevelText;
	public Text TotalPointsText;
	public Text TotalRoundsText;

	void Start () {
		GreetFunction ();
		GameControl.control.TotalScore = GameControl.control.TotalScore + GameControl.control.score;
		GameControl.control.score = 0;
		TotalPointsText.text = "Total Points : "+GameControl.control.TotalScore.ToString();
	}
	

	void Update () {
		LevelFunction ();
		CurrentLevelText.text = "Current Level : "+GameControl.control.Level.ToString();
		TotalRoundsText.text = "Total Rounds : "+GameControl.control.TotalRounds.ToString();
	}
	public void ScoreShareBtn()
	{
		Application.OpenURL ("https://www.facebook.com/dialog/feed?app_id=145634995501895&display=popup&caption=Let's play Quiz Buzz..!&description=I Got "+GameControl.control.TotalScore+" points . If you want to beat my score. Go and Play Quiz buzz at PlayStore and AppStore&link=https://play.google.com/store/apps/details?id=zopygames.com.quizbuzz&picture=http://www.zopy.in/apk/images/quizbuzz/logo.png&redirect_uri=http://www.facebook.com");
	}
	public void PlayAgainBtn()
	{
		Intestinal_Ad_Show ();
		Application.LoadLevel ("CategoriesScene");
	}
	void GreetFunction()
	{
		if (GameControl.control.score == 140) {
			GreetText.text = "Brilliant.....";
		}
		if (GameControl.control.score >= 100 && GameControl.control.score < 140) {
			GreetText.text = "Excellent.....";
		}
		if (GameControl.control.score >= 60 && GameControl.control.score < 100) {
			GreetText.text = "Very Good.....";
		}
		if (GameControl.control.score >= 30 && GameControl.control.score < 60) {
			GreetText.text = "Good.....";
		}
		if (GameControl.control.score >= 0 && GameControl.control.score < 30) {
			GreetText.text = "Needs lot of improvement.....";
		}

	}
	void LevelFunction()
	{
		if (GameControl.control.TotalScore >= 0 && GameControl.control.TotalScore < 100) {
			GameControl.control.Level = 0;
			LevelStatus.text = "You need " +(100 - GameControl.control.TotalScore)+ " points to go Level "+(GameControl.control.Level + 1);
		}
		if (GameControl.control.TotalScore >= 100 && GameControl.control.TotalScore < 260) {
			GameControl.control.Level = 1;
			LevelStatus.text = "You need " +(260 - GameControl.control.TotalScore)+ " points to go Level "+(GameControl.control.Level + 1);
		}
		if (GameControl.control.TotalScore >= 260 && GameControl.control.TotalScore < 500) {
			GameControl.control.Level = 2;
			LevelStatus.text = "You need " +(500 - GameControl.control.TotalScore)+ " points to go Level "+(GameControl.control.Level + 1);
		}
		if (GameControl.control.TotalScore >= 500 && GameControl.control.TotalScore < 760) {
			GameControl.control.Level = 3;
			LevelStatus.text = "You need " +(760 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 760 && GameControl.control.TotalScore < 1040) {
			GameControl.control.Level = 4;
			LevelStatus.text = "You need " +(1040 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 1040 && GameControl.control.TotalScore < 1340) {
			GameControl.control.Level = 5;
			LevelStatus.text = "You need " +(1340 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 1340 && GameControl.control.TotalScore < 1660) {
			GameControl.control.Level = 6;
			LevelStatus.text = "You need " +(1660 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 1660 && GameControl.control.TotalScore < 2000) {
			GameControl.control.Level = 7;
			LevelStatus.text = "You need " +(2000 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 2000 && GameControl.control.TotalScore < 2360) {
			GameControl.control.Level = 8;
			LevelStatus.text = "You need " +(2360 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 2360 && GameControl.control.TotalScore < 2740) {
			GameControl.control.Level = 9;
			LevelStatus.text = "You need " +(2740 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 2740 && GameControl.control.TotalScore < 3140) {
			GameControl.control.Level = 10;
			LevelStatus.text = "You need " +(3140 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 3140 && GameControl.control.TotalScore < 3560) {
			GameControl.control.Level = 11;
			LevelStatus.text = "You need " +(3560 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 3560 && GameControl.control.TotalScore < 4000) {
			GameControl.control.Level = 12;
			LevelStatus.text = "You need " +(4000 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 4000 && GameControl.control.TotalScore < 4460) {
			GameControl.control.Level = 13;
			LevelStatus.text = "You need " +(4460 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 4460 && GameControl.control.TotalScore < 4940) {
			GameControl.control.Level = 14;
			LevelStatus.text = "You need " +(4940 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 4940 && GameControl.control.TotalScore < 5440) {
			GameControl.control.Level = 15;
			LevelStatus.text = "You need " +(5440 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 5440 && GameControl.control.TotalScore < 5960) {
			GameControl.control.Level = 16;
			LevelStatus.text = "You need " +(5960 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 5960 && GameControl.control.TotalScore < 6500) {
			GameControl.control.Level = 17;
			LevelStatus.text = "You need " +(6500 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 6500 && GameControl.control.TotalScore < 7080) {
			GameControl.control.Level = 18;
			LevelStatus.text = "You need " +(7080 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 7080 && GameControl.control.TotalScore < 7680) {
			GameControl.control.Level = 19;
			LevelStatus.text = "You need " +(7680 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 7680 && GameControl.control.TotalScore < 8300) {
			GameControl.control.Level = 20;
			LevelStatus.text = "You need " +(8300 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 8300 && GameControl.control.TotalScore < 8960) {
			GameControl.control.Level = 21;
			LevelStatus.text = "You need " +(8960 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 8960 && GameControl.control.TotalScore < 9660) {
			GameControl.control.Level = 22;
			LevelStatus.text = "You need " +(9660 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 9660 && GameControl.control.TotalScore < 10400) {
			GameControl.control.Level = 23;
			LevelStatus.text = "You need " +(10400 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 10400 && GameControl.control.TotalScore < 11920) {
			GameControl.control.Level = 24;
			LevelStatus.text = "You need " +(11920 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 11920 && GameControl.control.TotalScore < 12740) {
			GameControl.control.Level = 25;
			LevelStatus.text = "You need " +(11920 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 11920 && GameControl.control.TotalScore < 12740) {
			GameControl.control.Level = 26;
			LevelStatus.text = "You need " +(12740 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 12740 && GameControl.control.TotalScore < 13640) {
			GameControl.control.Level = 27;
			LevelStatus.text = "You need " +(13640 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 13640 && GameControl.control.TotalScore < 14620) {
			GameControl.control.Level = 28;
			LevelStatus.text = "You need " +(14620 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 14620 && GameControl.control.TotalScore < 15680) {
			GameControl.control.Level = 29;
			LevelStatus.text = "You need " +(15680 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 15680 && GameControl.control.TotalScore < 16820) {
			GameControl.control.Level = 30;
			LevelStatus.text = "You need " +(16820 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 16820 && GameControl.control.TotalScore < 18120) {
			GameControl.control.Level = 31;
			LevelStatus.text = "You need " +(18120 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 18120 && GameControl.control.TotalScore < 19580) {
			GameControl.control.Level = 32;
			LevelStatus.text = "You need " +(19580 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 19580 && GameControl.control.TotalScore < 21200) {
			GameControl.control.Level = 33;
			LevelStatus.text = "You need " +(21200 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 21200 && GameControl.control.TotalScore < 22980) {
			GameControl.control.Level = 34;
			LevelStatus.text = "You need " +(22980 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 22980 && GameControl.control.TotalScore < 24920) {
			GameControl.control.Level = 35;
			LevelStatus.text = "You need " +(24920 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 24920 && GameControl.control.TotalScore < 27020) {
			GameControl.control.Level = 36;
			LevelStatus.text = "You need " +(27020 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 27020 && GameControl.control.TotalScore < 29280) {
			GameControl.control.Level = 37;
			LevelStatus.text = "You need " +(29280 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 29280 && GameControl.control.TotalScore < 31700) {
			GameControl.control.Level = 38;
			LevelStatus.text = "You need " +(31700 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 31700 && GameControl.control.TotalScore < 34280) {
			GameControl.control.Level = 39;
			LevelStatus.text = "You need " +(34280 - GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
		}
		if (GameControl.control.TotalScore >= 34280 && GameControl.control.TotalScore < 37020) {
			GameControl.control.Level = 40;
			LevelStatus.text = "You need " +(GameControl.control.TotalScore)+ " points to go "+(GameControl.control.Level + 1)+" Level";
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
