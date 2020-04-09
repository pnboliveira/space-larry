using UnityEngine;
/// <summary>
/// Title screen script
/// </summary>
public class menuScript : MonoBehaviour {

	void OnGUI()
	{
		const int buttonWidth = 84;
		const int buttonHeight = 60;
			
		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRect = new Rect(
			Screen.width / (2.5f) - (buttonWidth / 1),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
		);

		Rect buttonRect2 = new Rect(
			Screen.width / (1.6f) - (buttonWidth / 3),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);
			
		// Draw a button to start the game
		if(GUI.Button(buttonRect,"Start!"))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.LoadLevel(1);
		}

		if(GUI.Button(buttonRect2,"Quit"))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.Quit();
		}
	}
}
