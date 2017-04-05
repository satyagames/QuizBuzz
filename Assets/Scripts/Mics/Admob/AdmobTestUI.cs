using UnityEngine;
using System.Collections;
using com.microeyes.admob;

[ExecuteInEditMode]
public class AdmobTestUI : MonoBehaviour {

    private Rect m_rect = new Rect();

    void OnGUI()
    {
        DrawBannerAdvs();
        DrawInterstitialAdvs();

        m_rect.y = Screen.height - m_rect.height - 20;
        m_rect.x = Screen.width - m_rect.width;
    } 

    void DrawBannerAdvs()
    {
        m_rect.x = 20;
        m_rect.y = 50;

        m_rect.width = Screen.width * 0.2f;
        m_rect.height = Screen.height * 0.12f;
        
        if (GUI.Button(m_rect, "Create Banner"))
        {
            //AdmobManager.CreateBannerAd("Banner_1");  //Simple, with default options
            //OR
            BannerAd l_bannerAd = AdmobManager.Prepare<BannerAd>("Banner_1");
            l_bannerAd.BannerType = EBannerAdType.SMART_BANNER;
            l_bannerAd.Orientation = EOrientation.HORIZONTAL;
            l_bannerAd.AnimInType = EAnimationInType.FADE_IN;
            l_bannerAd.AnimOutType = EAnimationOutType.SLIDE_OUT_RIGHT;
            l_bannerAd.SetPosition(EPosition.CENTER_HORIZONTAL, EPosition.BOTTOM);
            
            //Admob Callbacks
            l_bannerAd.OnAdLoaded += MyCustom_OnAdLoadedEvent;

            l_bannerAd.Create();
        }

        m_rect.y = m_rect.y + m_rect.height;
        if (GUI.Button(m_rect, "Load Banner"))
        {
            AdmobManager.Load("Banner_1");
            //OR
            //BannerAd l_bannerAd = AdmobManager.Get<BannerAd>("Banner_1");
            //l_bannerAd.Load();
        }

        m_rect.y = m_rect.y + m_rect.height;
        
        if (GUI.Button(m_rect, "Show Adv"))
        {
            AdmobManager.ShowBanner("Banner_1");
            //OR
            //BannerAd l_bannerAd = AdmobManager.Get<BannerAd>("Banner_1");
            //l_bannerAd.Show();
        }

        m_rect.y = m_rect.y + m_rect.height;
        
        if (GUI.Button(m_rect, "Hide Adv"))
        {
            AdmobManager.HideBanner("Banner_1");
            //OR
            //BannerAd l_bannerAd = AdmobManager.Get<BannerAd>("Banner_1");
            //l_bannerAd.Hide();
        }

        m_rect.y = m_rect.y + m_rect.height;

        if (GUI.Button(m_rect, "Remove Immediately"))
        {
            AdmobManager.RemoveAdImmediately("Banner_1");
        }

        m_rect.y = m_rect.y + m_rect.height;

        if (GUI.Button(m_rect, "Reposition"))
        {
            BannerAd l_bannerAd = AdmobManager.Get<BannerAd>("Banner_1");
            l_bannerAd.Reposition(EPosition.TOP, EPosition.CENTER_HORIZONTAL);
        }

        m_rect.y = m_rect.y + m_rect.height;

        if (GUI.Button(m_rect, "Create with New AdUnitID"))
        {
            BannerAd l_newBanner = AdmobManager.Prepare<BannerAd>("banner_with_diff_unit_id");
            l_newBanner.AdUnitId = "ca-app-pub-4192487455949741/8385716917";
            l_newBanner.SetPosition(EPosition.CENTER_HORIZONTAL, EPosition.TOP);
            l_newBanner.Create();
            l_newBanner.Load();
        }
    }

    void DrawInterstitialAdvs()
    {
        m_rect.x += m_rect.width + 30.0f;
        m_rect.y = 40;

        m_rect.width = Screen.width * 0.25f;
        m_rect.height = Screen.height * 0.15f;

        if (GUI.Button(m_rect, "Create Interstitial Ad"))
        {
            InterstitialAd l_interAd = AdmobManager.PrepareInterstitialAd("Interstitial_1");
            //OR
            //InterstitialAd l_interAd = AdmobManager.Prepare<InterstitialAd>("Interstitial_1");
            l_interAd.AdUnitId = "ca-app-pub-4192487455949741/8306159319";
            l_interAd.Create();
        }

        m_rect.y = m_rect.y + m_rect.height;
        if (GUI.Button(m_rect, "Load Interstitial Ad"))
        {
            InterstitialAd l_interAd = AdmobManager.Get<InterstitialAd>("Interstitial_1");
            l_interAd.Load();
        }
        m_rect.y = m_rect.y + m_rect.height;

        if (GUI.Button(m_rect, "Show Interstitial Ad"))
        {
            InterstitialAd l_interAd = AdmobManager.Get<InterstitialAd>("Interstitial_1");
            l_interAd.Show();
        }

    }

    void MyCustom_OnAdLoadedEvent(string a_id)
    {
        Debug.LogError("MyCustom_OnAdLoadedEvent");
    }
    	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
	}
}
