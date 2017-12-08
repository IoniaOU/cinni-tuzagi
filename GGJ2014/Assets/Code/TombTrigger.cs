using UnityEngine;
using System.Collections;

public class TombTrigger : MonoBehaviour {

	public bool isOK = false;
	private bool isShoveling = false;
	public GameObject shovel;
	public GameObject handshovel;
	public GameObject woman;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (isShoveling)
		{
			transform.Translate(new Vector3(0,-0.01f,0));
		}
		if (transform.position.y < -1)
		{
			EnemyCode.die = true;
			woman.audio.Play();
			shovel.SetActive(true);
			handshovel.SetActive(false);
			Destroy(gameObject);
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player"&&isOK)
		{
			audio.Play();
			isShoveling=true;
		}
	}
}
