using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuController : MonoBehaviour {

    public GameObject pauseMenu;
    public GameObject instructionMenu;
    public bool isPaused;
    public bool isStart = true;

    private static int score;
    public Text changingText;
   // private static int lives;
   // public Text changingText2;


    // Use this for initialization
    void Start ()
    {
        

    }
	
	// Update is called once per frame
	void Update ()
    {
        //constantly updates the lives/score
        //LivesUpdate();
        ScoreUpdate();
        //open/close menu when esc is pressed
		if(OVRInput.Get(OVRInput.Button.Start))
        {
                isPaused = true;
                pauseMenu.SetActive(true);
                Time.timeScale = 0f;
                GetComponent<OVRPlayerController>().enabled = true;
        }
        if(OVRInput.Get(OVRInput.Button.Two))
        {
            resumeGame();
            isPaused = false;
            isStart = false;
        }
        if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger) && OVRInput.Get(OVRInput.RawButton.LIndexTrigger) && isPaused)
        {
            ResetGame();
            isPaused = false;
        }
        if(isStart)
        {
            Time.timeScale = 0f;
            instructionMenu.SetActive(true);
        }
       
    }
    //closes menu, resume time
    public void resumeGame()
    {
        isPaused = false;
        isStart = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        instructionMenu.SetActive(false);
    }


    public void ResetGame()
    {
        //reload current scene,resumes time and resets lives/score
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 0f;
        PlayerController2.Points = 0;
        score = 0;
        isStart = true;
        instructionMenu.SetActive(true);
    }

    public void ScoreUpdate()
    {
        //Update score text with points variable in alien script
        score = PlayerController2.Points;
        changingText.text = "Current Score: " + score.ToString();
    }
    /*
    public void LivesUpdate()
    {
        //update lives left with lives variable from playercontroller
        lives = PlayerController.PlayerLives;
        changingText2.text = "Lives Left: " + lives.ToString();
    }*/


}
