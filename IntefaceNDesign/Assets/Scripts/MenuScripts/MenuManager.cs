using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void BackButton() //To go back from other pages to menu 
    {
        Application.LoadLevel("MenuScene");
    }

    public void OptionsButton()
    {
        Application.LoadLevel("OptionScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
