using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {

	//bools used for movement
	private bool moveUp;
	private bool moveDown;
	private bool moveRight;
	private bool moveLeft;

	//float used to move
	private float moveTimer;

	void Start () 
	{
		//turns all the bools on, so the player is able to move
		moveUp = true;
		moveDown = true;
		moveRight = true;
		moveLeft = true;
		//enables the player to move
		moveTimer = 1.5f;
	}

	void FixedUpdate () 
	{
		//player can only move if the movetimer is 2
		if(moveTimer >= 1.5)
		{
			//moving up
			if (Input.GetKey (KeyCode.UpArrow) && moveUp || Input.GetKey (KeyCode.W) && moveUp)
			{
				this.transform.Translate(0.0f, 0.0f, 32.0f);
				moveDown = true;
				moveRight = true;
				moveLeft = true;
				moveTimer = 0;
			}
			//moving down
			else if (Input.GetKey (KeyCode.DownArrow) && moveDown || Input.GetKey (KeyCode.S) && moveDown)
			{
				this.transform.Translate(0.0f, 0.0f, -32.0f);
				moveUp = true;
				moveRight = true;
				moveLeft = true;
				moveTimer = 0;
			}
			//moving right
			else if (Input.GetKey (KeyCode.RightArrow) && moveRight || Input.GetKey (KeyCode.D) && moveRight)
			{
				this.transform.Translate(32.0f, 0.0f, 0.0f);
				moveUp = true;
				moveDown = true;
				moveLeft = true;
				moveTimer = 0;
			}
			//moving left
			else if (Input.GetKey (KeyCode.LeftArrow) && moveLeft || Input.GetKey (KeyCode.A) && moveLeft)
			{
				this.transform.Translate(-32.0f, 0.0f, 0.0f);
				moveUp = true;
				moveDown = true;
				moveRight = true;
				moveTimer = 0;
			}
		}
		//makes the player being able to move again
		if(moveTimer < 1.5)
		{
			moveTimer += 0.1f;
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
