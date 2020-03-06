using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoInimigo : MonoBehaviour
{

	public float speed = -1;
	private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2 (speed,0);
    }

  void OnTriggerEnter2D(Collider2D outro){
		if (outro.gameObject.tag == "bala") {
		Destroy(gameObject);	
                }
		if (outro.gameObject.tag == "celeiro") {
			Destroy(gameObject);	
		}
     }
}



  