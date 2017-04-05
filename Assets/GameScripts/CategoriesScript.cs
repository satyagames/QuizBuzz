using UnityEngine;
using System.Collections;

public class CategoriesScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void GeneralKnowledgeBtn()
	{
		Application.LoadLevel ("GeneralKnowledge");
	}
	public void AptitudeReasoningBtn()
	{
		Application.LoadLevel ("AptitudeReasoning");
	}

	public void ElectricalEngineeringSubBtn()
	{
		Application.LoadLevel ("ElectricalEngineeringSubCategories");
	}
	public void ElectronicsEngineeringBtn()
	{
		Application.LoadLevel ("ElectronicsEngineering");
	}
	public void ElectricalEngineeringBtn()
	{
		Application.LoadLevel ("ElectricalEngineering");
	}
	public void ComputerTechnologyBtn()
	{
		Application.LoadLevel ("ComputerSubCategories");
	}
	public void LawEducationBtn()
	{
		Application.LoadLevel ("Law");
	}

	public void ControlSystemsBtn()
	{
		Application.LoadLevel ("ControlSystems");
	}
	public void PowerSystemsBtn()
	{
		Application.LoadLevel ("PowerSystems");
	}

	public void ComputerBasicsBtn()
	{
		Application.LoadLevel ("ComputerBasics");
	}
	public void ComputerProgrammingBtn()
	{
		Application.LoadLevel ("ComputerProgramming");
	}
	public void BackToCategoriesBtn()
	{
		Application.LoadLevel ("CategoriesScene");
	}
}
