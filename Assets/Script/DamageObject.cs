using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour
{
	public HPManager HPManager;
	public float Damage;

	void Start(){
	HPManager = FindObjectOfType<HPManager>();
	}

	private void OnCollisionEnter(Collision collision){
		if(collision.gameObject.CompareTag("Player")){

		if(HPManager.UpdateHP(Damage)){
			Destroy(gameObject);
		}
		}
	}
}
