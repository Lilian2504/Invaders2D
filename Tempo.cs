using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tempo : MonoBehaviour
{

	public Text displayContagem;
	public float contagem=10f;
	public Text countText;
	public GameObject EndText;
	public GameObject pause;
    // Start is called before the first frame update
    void Start()
    {
		InvokeRepeating ("Diminui", 0.0f, 0.1f);
    }

    // Update is called once per frame
    void Diminui()
    {
		if (contagem > 0.0f) {
			contagem -= 0.1f;
			displayContagem.text = contagem.ToString ("F2");
		} else
		{
			displayContagem.text = "0";
			EndText.SetActive (true);
			pause.SetActive (false);

		}
    }
	
}
