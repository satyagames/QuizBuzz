using UnityEngine;
using System.Collections;

public class OptionDButtonClick : MonoBehaviour {
	Animator Anim;
	public AudioSource AudioSource;
	public AudioClip RightClip;
	public AudioClip WrongClip;
	// Use this for initialization
	void Start () {
		Anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		DAnimationCheck ();
	}
	public void DClick()
	{
		DAnimationCheck ();

		if (GameControl.control.isDCorrect) 
		{
			GameControl.control.isDCorrect = false;
			GameControl.control.score = GameControl.control.score + 20; 
			AudioSource.clip = RightClip;
			AudioSource.Play ();
		} else {
			AudioSource.clip = WrongClip;
			AudioSource.Play ();
		}

	}
	void DAnimationCheck()
	{
		Anim.SetBool ("isCorrectD",GameControl.control.DCorrectAnswer);
		Anim.SetBool ("isWrongD",GameControl.control.DWrongAnswer);
	}
}
