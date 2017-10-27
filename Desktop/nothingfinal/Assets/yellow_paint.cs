using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellow_paint: MonoBehaviour {
	private GameObject target;
	public GameObject brush;
	public Canvas canvas;
	float next_brush_time;
	//Use this for initialization
	void Start(){
		target = GameObject.Find ("ARCamera");
		next_brush_time = Time.time + 1f;
	}

	//Update is called once per frame
	void Update(){
		transform.LookAt (target.transform);

		if (Input.GetKeyDown ("space")) {
			canvas.enabled = false;
		}

		if (Input.GetKeyDown ("a")) {
			canvas.enabled = true;
		}
		if (Input.GetMouseButton (0)) {		
			Instantiate (canvas, target.transform.position, target.transform.rotation);
			//next_brush_time+=if;
		}
		//Instantiate(target,transform.position,transform.rotation);
	}
}