using UnityEngine;
using System.Collections;

public class TorchTrigger : MonoBehaviour {

	public GameObject torch; 
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			torch.SetActive(true);
			Destroy(gameObject);
		}
	}
}
