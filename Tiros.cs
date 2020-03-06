using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiros : MonoBehaviour
{
	public float velTiros;
	public float tempoVida;


	void Start () {
		
	}

	void onEnable(){
		Invoke ("Desligar", tempoVida);
	}

	void Desligar(){
		gameObject.SetActive (false);
	}

	void onDisabled(){
		CancelInvoke ();
	}
	void Update()
	{
		transform.position += new Vector3 (0, -velTiros, 0)*Time.deltaTime; 
	}


	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "vaca"){
			Acertos.acertos++;

		}
	}


}

    public static class Acertos{

	public static int acertos=0;




}

