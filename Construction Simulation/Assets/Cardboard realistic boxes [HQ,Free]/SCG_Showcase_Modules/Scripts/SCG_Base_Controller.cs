using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEngine.UI;

[ExecuteInEditMode]
public class SCG_Base_Controller : MonoBehaviour 
{
	[Header("     Modules material setup")]
	public Color wallsColor = new Color(1f,1f,1f,1f);
	public Color baseColor = new Color(0.235f,0.235f,0.235f,1f);
	[Header("     Text setup")]
	public Color textColor = new Color(1f,1f,1f,1f);
	public string baseText;
	[Header("     Lighting setup")]
	public Color lightColor = new Color(1f,1f,1f,1f);
	public float lightIntensity = 1.0f;

	Material mat01;
	Material mat02;
	Text textEditor;
	Light pointLight;


	void Update ()
	{
	//Initialize components
		mat01 = this.GetComponent<MeshRenderer>().sharedMaterials.GetValue(0) as Material;
		mat02 = this.GetComponent<MeshRenderer>().sharedMaterials.GetValue(1) as Material;
		textEditor = this.GetComponentInChildren<Text>();
		pointLight = this.GetComponentInChildren<Light>();

	//Do something
		mat01.color = baseColor;
		mat02.color = wallsColor; 
		textEditor.text = baseText;
		textEditor.color = textColor;
		pointLight.color = lightColor;
		pointLight.intensity = lightIntensity;
	}

	void OnRenderObject () 
	{

	}
}
