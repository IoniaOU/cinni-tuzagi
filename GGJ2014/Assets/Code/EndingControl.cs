using UnityEngine;
using System.Collections;

public class EndingControl : MonoBehaviour {

	public GameObject firstpaper;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			if(!firstpaper.GetComponent<PaperControl>().farlar)
			{
				Application.LoadLevel(1);
			}
		}
	}
}
