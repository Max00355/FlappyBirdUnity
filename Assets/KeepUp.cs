using UnityEngine;
using System.Collections;

public class KeepUp : MonoBehaviour
{
	public Vector2 position = new Vector2 (0, 0);
	public float gravity = 0.001f;
	public float gravity_max = 0.3f;
	public float gravity_at = 0;
	public float jumping = 0;

	void Start ()
	{
		
	}

	void Jump() {
		position.y += jumping;
		jumping -= 0.01f;
	}

	void Gravity() {
		if (this.gravity_at < this.gravity_max) {
			this.gravity_at += this.gravity;
		}

		this.position.y -= this.gravity_at;
	}

	void Update ()
	{	
		if (Input.GetKeyDown (KeyCode.Space)) {
			jumping = 0.1f;
			gravity_at = 0;
		}

		if (jumping == 0) {
			this.Gravity ();
		} else {
			this.Jump ();
		}
		gameObject.transform.position = this.position;

	}
}

