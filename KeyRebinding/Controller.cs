using UnityEngine;
using System.Collections;

/*
This class represents a controller script for player movement in a game. It inherits from the MonoBehaviour class.

The class has a Start() method that runs at the start of the game and sets the cursor visibility to false and locks it to the center of the screen.

The class has an Update() method that is called every frame. Within this method:

If the forward key is pressed, it moves the player forward based on the transform's forward direction.
If the backward key is pressed, it moves the player backward based on the opposite of the transform's forward direction.
If the left key is pressed, it moves the player to the left based on the opposite of the transform's right direction.
If the right key is pressed, it moves the player to the right based on the transform's right direction.
If the jump key is pressed, it moves the player upward based on the transform's up direction.
It sets the cursor visibility to true and unlocks the cursor if any key is pressed.
Note: GameManager.GM refers to the GameManager class, which likely contains key mappings or references to input actions.
*/

public class Controller : MonoBehaviour {

   

	void Start ()
	{
	 Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
	}

	void Update () 
	{

		if(Input.GetKey(GameManager.GM.forward))
			transform.position += transform.forward / 18;
	
		if( Input.GetKey(GameManager.GM.backward))
			transform.position += -transform.forward / 18;
		
		if( Input.GetKey(GameManager.GM.left))
			transform.position += -transform.right / 18;
		
		if( Input.GetKey(GameManager.GM.right))
			transform.position += transform.right / 18;

		if( Input.GetKey(GameManager.GM.jump))
			transform.position += transform.up / 2;
                  
                  Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
	}
}