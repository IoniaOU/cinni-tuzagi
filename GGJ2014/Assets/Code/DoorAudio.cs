using UnityEngine;
using System.Collections;

public class DoorAudio : MonoBehaviour {
	
	public float buffer;
	// Use this for initialization
	void Start ()
	{
		Screen.showCursor = false;
		buffer = Random.Range (10, 50);
	}
	
	// Update is called once per frame
	void Update ()
	{
		buffer -= Time.deltaTime;
		if (buffer<0)
		{
			audio.Play();
			buffer = Random.Range (10, 50);
		}
	}
}
