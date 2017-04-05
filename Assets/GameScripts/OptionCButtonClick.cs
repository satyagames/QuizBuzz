using UnityEngine;
using System.Collections;

public class OptionCButtonClick : MonoBehaviour {
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
		CAnimationCheck ();
	}
	public void CClick()
	{
		CAnimationCheck ();
		if (GameControl.control.isCCorrect) 
		{
			GameControl.control.isCCorrect = false;
			GameControl.control.score = GameControl.control.score + 20; 
			AudioSource.clip = RightClip;
			AudioSource.Play ();
		} else {
			AudioSource.clip = WrongClip;
			AudioSource.Play ();
		}

	}
	void CAnimationCheck()
	{
		Anim.SetBool ("isCorrectC",GameControl.control.CCorrectAnswer);
		Anim.SetBool ("isWrongC",GameControl.control.CWrongAnswer);
	}
}
