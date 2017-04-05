using UnityEngine;
using System.Collections;
using com.microeyes.admob;

public class StartScript : MonoBehaviour {

	void Start () {
		BannerAd l_newBanner = AdmobManager.Prepare<BannerAd>("Banner-1");
		l_newBanner.AdUnitId = "ca-app-pub-6065714673957825/1329600461";
		//l_newBanner.SetPosition(EPosition.CENTER_HORIZONTAL, EPosition.TOP);
		
		l_newBanner.BannerType = EBannerAdType.BANNER;
		l_newBanner.Orientation = EOrientation.HORIZONTAL;
		l_newBanner.AnimInType = EAnimationInType.FADE_IN;
		l_newBanner.AnimOutType = EAnimationOutType.SLIDE_OUT_RIGHT;
		l_newBanner.SetPosition(EPosition.CENTER, EPosition.BOTTOM);
		
		l_newBanner.Create();
		
		l_newBanner.Load();

		Intestinal_Ad_Create ();

		StartCoroutine("MoveScreen");
	}

	void Update () {
	
	}
	IEnumerator MoveScreen()
	{
		yield return new WaitForSeconds (2);
		Application.LoadLevel ("Title");
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
	
	/*IEnumerator Intestinal_Ad() {
		Intestinal_Ad_Create ();
		yield return new WaitForSeconds(2);
		Intestinal_Ad_Load ();
		yield return new WaitForSeconds(3);
		Intestinal_Ad_Show ();
		Intestinal_Ad_Show ();
	}*/
}
