using UnityEngine;
using System.Collections;

public class OptionAButtonClick : MonoBehaviour {
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
		AAnimationCheck ();
	}
	public void AClick()
	{
		AAnimationCheck ();
		if (GameControl.control.isACorrect) {
			GameControl.control.isACorrect = false;
			GameControl.control.score = GameControl.control.score + 20; 
			AudioSource.clip = RightClip;
			AudioSource.Play ();
		} else {
			AudioSource.clip = WrongClip;
			AudioSource.Play ();
		}

	}
	void AAnimationCheck()
	{
		Anim.SetBool ("isCorrectA",GameControl.control.ACorrectAnswer);
		Anim.SetBool ("isWrongA",GameControl.control.AWrongAnswer);

	}

}
