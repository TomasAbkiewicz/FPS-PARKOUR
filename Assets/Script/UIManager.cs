using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
public TextMeshProUGUI txtMoney;
public TextMeshProUGUI txtHP;
public void UpdateMoneyText(string money){
	txtMoney.text = "$" + money;
}
public void UpdateHPText(string HP){
	txtHP.text = HP + "HP";
}
}
