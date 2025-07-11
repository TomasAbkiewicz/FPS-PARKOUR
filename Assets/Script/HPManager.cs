using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HPManager : MonoBehaviour
{
	public float HP; 
	public UIManager uiManager;

	void Start(){
		uiManager = FindObjectOfType<UIManager>();
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
