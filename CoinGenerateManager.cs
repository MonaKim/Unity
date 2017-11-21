using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerateManager : MonoBehaviour {

	public GameObject[] coins = new GameObject[2];


	public void generateCoin(){
		int randomVal = Convert.ToInt32(Mathf.Round( UnityEngine.Random.value));
		GameObject.Instantiate( coins[randomVal], new Vector3(0,0,0), Quaternion.identity);
	}


}
