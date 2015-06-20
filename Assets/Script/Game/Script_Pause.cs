using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_Pause : MonoBehaviour {

	public Button PauseButton;
	public Image WhiteImage;
	public Button ResumeButton;
	public Button StopButton;
	public Button RestartButton;
	// Use this for initialization
	void Start () {
		PauseButton.onClick.AddListener (Pause);
		ResumeButton.onClick.AddListener (Resume);
		StopButton.onClick.AddListener (Stop);
		RestartButton.onClick.AddListener (Restart);
		Settings (false);
	}
	void Pause()
	{
		Time.timeScale = 0;
		Settings (true);
	}
	void Resume()
	{
		Time.timeScale = 1;
		Settings (false);
	}
	void Stop()
	{
		Time.timeScale = 1;
		Application.LoadLevel ("Start");
	}
	void Restart()
	{
		Time.timeScale = 1;
		Application.LoadLevel ("InGame");
	}
	void Settings(bool enabled)
	{
		WhiteImage.enabled = enabled;
		ResumeButton.GetComponent<Image> ().enabled = enabled;
		StopButton.GetComponent<Image> ().enabled = enabled;
		RestartButton.GetComponent<Image> ().enabled = enabled;
	}
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Menu) || Input.GetKeyDown(KeyCode.Home))
		{
			if(Time.timeScale==1)
			{
				Pause();
			}
			else
			{
				Resume();
			}
		}
	}
	public void OnApplicationPause(bool focus)
	{
		if (focus) {
			Resume ();
		} else {
			Pause ();
		}
	}

}
