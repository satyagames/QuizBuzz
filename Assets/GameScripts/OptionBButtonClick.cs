using UnityEngine;
using System.Collections;

public class OptionBButtonClick : MonoBehaviour {
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
		BAnimationCheck ();
	}
	public void BClick()
	{
		BAnimationCheck ();
		if (GameControl.control.isBCorrect) 
		{
			GameControl.control.isBCorrect = false;
			GameControl.control.score = GameControl.control.score + 20;
			AudioSource.clip = RightClip;
			AudioSource.Play ();
		} else {
			AudioSource.clip = WrongClip;
			AudioSource.Play ();
		}

	}
	void BAnimationCheck()
	{
		Anim.SetBool ("isCorrectB",GameControl.control.BCorrectAnswer);
		Anim.SetBool ("isWrongB",GameControl.control.BWrongAnswer);
	}
}
