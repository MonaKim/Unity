using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinRaise : MonoBehaviour {

	private float raiseSpeed = 10.0f;
	private bool reach = false;

	public int scale = 2;
	private Animator coinAnimator;

	void Start(){
		raiseSpeed += Random.value * scale;
		coinAnimator = gameObject.transform.GetChild(0).gameObject.GetComponent<Animator>();
	}
	
	void Update () {
		transform.Translate(new Vector2(raiseSpeed,0) * Time.deltaTime);

		if(transform.position.x >= 17.0f){
			if(reach == false){
				reach = true;

				StartCoroutine(selfDestruction());
				coinAnimator.SetBool("reach",true);
				GameObject moon = GameObject.Find("Moon");
				print(moon);
				moonAnimationManager moonAniManager = moon.GetComponent<moonAnimationManager>();
				moonAniManager.goNextFrame();
			}
		}
	}

	private IEnumerator selfDestruction(){
		yield return new WaitForSeconds(0.25f);
		Destroy(this.gameObject);
	}


}
