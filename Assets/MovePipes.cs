using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipes : MonoBehaviour {

	private float height;
	private float width;
	public float speed = 0.03F;
	private float offset_direction = -1;

	void Start () {
		this.height = 2f * Camera.main.orthographicSize;
		this.width = this.height / 2 * Camera.main.aspect;

	}
				
	float GetOffset() {
		offset_direction *= -1;
		return offset_direction * -1 * Random.value;
	}

	void Update () {
		GameObject top_pipe = GameObject.Find("top_pipe");
		GameObject bottom_pipe = GameObject.Find("bottom_pipe");
		Vector2 tpv = top_pipe.transform.position;
		Vector2 bpv = bottom_pipe.transform.position;

		tpv.x -= this.speed;
		bpv.x -= this.speed;

		if (bpv.x < -this.width) {
			float offset = this.GetOffset ();
			tpv.y += offset;
			bpv.y += offset;
			bpv.x = this.width;
			tpv.x = this.width;
		}

		top_pipe.transform.position = tpv;
		bottom_pipe.transform.position = bpv;
	}
		
}
