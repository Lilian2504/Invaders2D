using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MovimentoJogador : MonoBehaviour
{
	// Start is called before the first frame update
	public float velocidadeF;
	public float tiroInicial;
	public float tiroContinuo;
	public GameObject tiros;
	public Text countText;
	public Text EndText;
	public int numeroTiros;
	List<GameObject>listaTiros;

	// Start is called before the first frame update
	void Start()
	{
		listaTiros = new List <GameObject> ();
		for (int i = 0; i < numeroTiros; i++) {
			GameObject obj = (GameObject)Instantiate (tiros);
			obj.SetActive (false);
			listaTiros.Add (obj);
		}
	}




	// Update is called once per frame
	void Update()
	{
		if(Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector2.left*velocidadeF * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector2.left*-velocidadeF * Time.deltaTime);
		}  

		if (Input.GetKeyDown (KeyCode.Space)) {
			InvokeRepeating ("Atirar", tiroInicial, tiroContinuo);

		} else if (Input.GetKeyUp (KeyCode.Space)) {
			CancelInvoke("Atirar");

		}
		SetCountText ();
	}

	void Atirar(){
		for (int i = 0; i < listaTiros.Count; i++) {
			if (!listaTiros[i].activeInHierarchy){
				listaTiros [i].transform.position = transform.position;
				listaTiros [i].transform.rotation = transform.rotation;
				listaTiros [i].SetActive (true);
				break;
			}

		}


		}
	void SetCountText() {
		
		countText.text = "Count: " + Acertos.acertos.ToString();
		EndText.text = "Você matou: " + Acertos.acertos.ToString()+" vacas";
	}


}