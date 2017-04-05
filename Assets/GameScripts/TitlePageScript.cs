using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TitlePageScript : MonoBehaviour {
	public Button PlayButton;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void PlayBtn()
	{
		Application.LoadLevel ("CategoriesScene");
	}

	public void FBShare(){
		Application.OpenURL ("https://www.facebook.com/dialog/feed?app_id=145634995501895&display=popup&caption=Let's play Quiz Buzz..!&description=Play this awesome game for fun&link=https://play.google.com/store/apps/details?id=zopygames.com.quizbuzz&picture=http://www.zopy.in/apk/images/quizbuzz/logo.png&redirect_uri=http://www.facebook.com");
		GameControl.control.score = GameControl.control.score + 1000;
	}
	public void GPLUSShare(){
		Application.OpenURL ("https://plus.google.com/share?url=https://play.google.com/store/apps/details?id=zopygames.com.quizbuzz");
		GameControl.control.score = GameControl.control.score + 1000;
	}
}
