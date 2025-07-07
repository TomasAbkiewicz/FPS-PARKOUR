using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HPManager : MonoBehaviour
{
	public float HP; 
	public UI_Manager UIManager;

	void Start(){
		uiManager = FindObjectOfType<UI_Manager>();
	}

	public bool UpdateHP (float damage){
		if(HP <= damage){
			SceneManager.LoadScene("SampleScene");
			return false; 
		}
		else{
			HP -= damage;
			uiManager.UpdateHPText(HP.ToString());
			return true;
		}
	}
}
