using UnityEngine;
using System.Collections;

public class ShovelTrigger : MonoBehaviour {

	public GameObject shovel;
	public GameObject tomb;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			shovel.SetActive(true);
			tomb.GetComponent<TombTrigger>().isOK = true;
			Destroy(gameObject);
		}
	}

}
