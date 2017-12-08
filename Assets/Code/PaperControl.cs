using UnityEngine;
using System.Collections;

public class PaperControl : MonoBehaviour
{
	public GUITexture papergui;
	public bool farlar = true;
	public Light far1;
	public Light far2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			papergui.enabled = true;
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			papergui.enabled = false;
			if (name == "Paper1")
			{
				if (farlar)
				{
					Ending.endingOption = 3;
					audio.Play ();
					farlar = false;
					far1.enabled = false;
					far2.enabled = false;
				}
			}
		}
	}
}
