using UnityEngine;
using System.Collections;

public class EnemyCode : MonoBehaviour {

	public static bool die = false;
	public bool voiceOK = true;
	public GameObject voice;
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update () {
		if (die)
		{
			this.GetComponent<Torchelight>().MaxLightIntensity -= Time.deltaTime/75;
		}

		if (this.GetComponent<Torchelight> ().MaxLightIntensity < 0)
		{
			Ending.endingOption = 4;
			Application.LoadLevel(1);
		}
	}
}
