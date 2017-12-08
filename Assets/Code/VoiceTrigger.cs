using UnityEngine;
using System.Collections;

public class VoiceTrigger : MonoBehaviour {

	public bool isOK = true;
	public GameObject news;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!isOK&&name=="Coins"&&GameObject.Find("coinmt") != null)
		{
			Destroy(transform.GetChild(0).gameObject);
			Ending.endingOption = 1;
		}
	
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player"&&isOK)
		{
			audio.Play();
			isOK = false;
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player"&&name == "NewsTrigger")
		{
			news.SetActive(false);
		}
	}

}
