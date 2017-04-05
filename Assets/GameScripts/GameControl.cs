using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameControl : MonoBehaviour {

	public static GameControl control;

	public int score;
	public int Level;
	public int TotalScore;
	public int TotalRounds;

	public bool isACorrect = false;
	public bool isBCorrect = false;
	public bool isCCorrect = false;
	public bool isDCorrect = false;

	public bool ACorrectAnswer = false;
	public bool BCorrectAnswer = false;
	public bool CCorrectAnswer = false;
	public bool DCorrectAnswer = false;
	public bool AWrongAnswer = false;
	public bool BWrongAnswer = false;
	public bool CWrongAnswer = false;
	public bool DWrongAnswer = false;

	void Update()
	{
		Quit ();
	}
	public void Quit()
	{
		if (Application.platform == RuntimePlatform.Android) {
			
			if (Input.GetKeyUp(KeyCode.Escape)) {
				Application.Quit();
			}
		}
	}
	void Awake()
	{
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
		}
		else if (control != this){
			Destroy(gameObject);
		}
	}

	void OnEnable() {
		Load ();
	}
	void OnDisable() {
		Save ();
	}
	public void Save()
	{
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/playerInfoQB.dat" );
		
		PlayerData data = new PlayerData();

		data.Level = Level;
		data.TotalScore = TotalScore;
		data.TotalRounds = TotalRounds;


		Debug.Log ("data Saved..."+Application.loadedLevelName);
		bf.Serialize (file, data);
		file.Close ();
	}
	public void Load()
	{
		if (File.Exists (Application.persistentDataPath + "/playerInfoQB.dat")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/playerInfoQB.dat", FileMode.Open);
			Debug.Log("file loads..."+Application.loadedLevelName);
			PlayerData data = (PlayerData)bf.Deserialize (file);
			file.Close ();



			Level = data.Level;
			TotalScore = data.TotalScore;
			TotalRounds = data.TotalRounds;


		} 
	}

}

[Serializable]
class PlayerData
{
	//public float score;
	public int Level;
	public int TotalScore;
	public int TotalRounds;

}
