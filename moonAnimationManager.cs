using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moonAnimationManager : MonoBehaviour {

	public Sprite[] moonSequence = new Sprite[14];
	public SpriteRenderer moonRenderer;
	public Animator moonAnimator;

	private int currentSpriteNum;
	private bool counterActive = true;


	// // Use this for initialization
	// void Start () {
		
	// }
	
	// // Update is called once per frame
	// void Update () {
		
	// }


	public void goNextFrame(){

		if(counterActive != true){
			return;
		}

		currentSpriteNum++;

		if(currentSpriteNum > 13){
			currentSpriteNum = 0;
		}
		else if(currentSpriteNum == 13){
			moonAnimator.SetBool("blink",true);
			counterActive = false;
			StartCoroutine(stopBlink());
		}
		moonRenderer.sprite = moonSequence[currentSpriteNum];
	}

	private IEnumerator stopBlink()
    {
        yield return new WaitForSeconds(0.5f);
        moonAnimator.SetBool("blink",false);
        yield return new WaitForSeconds(1.5f);
        counterActive = true;
        moonRenderer.sprite = moonSequence[0];
    }


}
