using UnityEngine;
using System.Collections;

public class VillageEnding : MonoBehaviour {

	public bool isOK = true;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player"&&isOK)
		{
			isOK = false;
			Ending.endingOption = 2;
		}
	}
}
