using UnityEngine;
using System.Collections;

public class WallControl : MonoBehaviour {

	public GameObject WallVoice;


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			WallVoice.audio.Play();
		}
	}
}
