using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {

	//bools used for movement
	private bool moveUp;
	private bool moveDown;
	private bool moveRight;
	private bool moveLeft;

	void Start () 
	{
		//turns all the bools on, so the player is able to move
		moveUp = true;
		moveDown = true;
		moveRight = true;
		moveLeft = true;
	}

	void Update () 
	{
		//moving up
		if (Input.GetKeyDown (KeyCode.UpArrow) && moveUp || Input.GetKeyDown (KeyCode.W) && moveUp)
		{
			this.transform.Translate(0.0f, 0.0f, 32.0f);
			moveDown = true;
			moveRight = true;
			moveLeft = true;
		}
		//moving down
		else if (Input.GetKeyDown (KeyCode.DownArrow) && moveDown || Input.GetKeyDown (KeyCode.S) && moveDown)
		{
			this.transform.Translate(0.0f, 0.0f, -32.0f);
			moveUp = true;
			moveRight = true;
			moveLeft = true;
		}
		//moving right
		else if (Input.GetKeyDown (KeyCode.RightArrow) && moveRight || Input.GetKeyDown (KeyCode.D) && moveRight)
		{
			this.transform.Translate(32.0f, 0.0f, 0.0f);
			moveUp = true;
			moveDown = true;
			moveLeft = true;
		}
		//moving left
		else if (Input.GetKeyDown (KeyCode.LeftArrow) && moveLeft || Input.GetKeyDown (KeyCode.A) && moveLeft)
		{
			this.transform.Translate(-32.0f, 0.0f, 0.0f);
			moveUp = true;
			moveDown = true;
			moveRight = true;
		}
	}

	void OnTriggerStay (Collider obj)
	{
		// collision check up
		if (this.transform.position.z + 32 == obj.transform.position.z && this.transform.position.x == obj.transform.position.x)
		{
			moveUp = false;
		}
		// collision check down
		if (this.transform.position.z - 32 == obj.transform.position.z && this.transform.position.x == obj.transform.position.x)
		{
			moveDown = false;
		}
		// collision check right
		if (this.transform.position.x + 32 == obj.transform.position.x && this.transform.position.z == obj.transform.position.z)
		{
			moveRight = false;
		}
		// collision check left
		if (this.transform.position.x - 32 == obj.transform.position.x && this.transform.position.z == obj.transform.position.z)
		{
			moveLeft = false;
		}
	}
}
