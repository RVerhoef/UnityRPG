using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WorldMenuScript : MonoBehaviour {

	//contains the entire menu
	[SerializeField]private GameObject menu;

	//bool used to determine if the menu is active or not
	private bool menuActive;

	// Use this for initialization
	void Start () 
	{
		//menu is not active at the start
		menu.SetActive (false);
		//menu boolean is not active at the start
		menuActive = false;
	}

	void Update () 
	{
		//if tab is pressed, the menu either activates or deactivates
		if(Input.GetKeyDown(KeyCode.Tab))
		{
			//if the menu is deactivated, it is activated and the game is paused
			if(!menuActive)
			{
				menu.SetActive (true);
				menuActive = true;
				Time.timeScale = 0f;
			}
			//if the menu is activated, it is deactivated and the game is unpaused
			else
			{
				menu.SetActive (false);
				menuActive = false;
				Time.timeScale = 1f;
			}
		}
	}
}
