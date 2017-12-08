using UnityEngine;
using System.Collections;

public class Ending : MonoBehaviour {
	public static int endingOption = 0;
	// Use this for initialization
	void Start ()
	{
		if (endingOption == 1)
		{
			gameObject.guiText.text = "Altınları alıp köyden kaçabildin.\nBundan sonraki hayatında asla o lanetli köye tekrar uğramadın.\nUzun, huzurlu ve zengin bir hayat yaşadın.\n\nMustafa Tufan, Kerim Torun, Murat Yücedağ, Mehmet Aslantaş, Emre Tekince\n\nOyunu kapatmak ESC tuşuna basın.";
		}
		if (endingOption == 2)
		{
			gameObject.guiText.text = "Köyde biraz dolaştıktan sonra altınları bulamadan kaçtın.\nO lanetli köyden canını kurtardığın için çok mutlusun.\n\nMustafa Tufan, Kerim Torun, Murat Yücedağ, Mehmet Aslantaş, Emre Tekince\n\nOyunu kapatmak ESC tuşuna basın.";
		}
		if (endingOption == 3)
		{
			gameObject.guiText.text = "Köyde bir gariplik olduğunu anlar anlamaz o lanetli yerden kaçtın.\nO köye girmediğin için gayet mutlusun.\n\nMustafa Tufan, Kerim Torun, Murat Yücedağ, Mehmet Aslantaş, Emre Tekince\n\nOyunu kapatmak ESC tuşuna basın.";
		}
		if (endingOption == 4)
		{
			gameObject.guiText.text = "Senin de kaderin köylüler ve daha önce hazine için oraya gelenler gibi oldu.\nRuhun cinlerle birlikte kıyamete dek o köyde tutsak kaldı.\n\nMustafa Tufan, Kerim Torun, Murat Yücedağ, Mehmet Aslantaş, Emre Tekince\n\nOyunu kapatmak ESC tuşuna basın.";
		}
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}
