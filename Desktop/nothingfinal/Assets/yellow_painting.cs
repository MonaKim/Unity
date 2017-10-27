using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellow_painting : MonoBehaviour {
	public GameObject yellow_paint;

	//Update is called once per frame
	void Update(){
		
		if(Input.GetMouseButton(0))
		{
				Instantiate(yellow_paint,transform.position,transform.rotation);

	    }
	}
}
