using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TestBooleans : MonoBehaviour
{
    private GameObject passwordRequirements;
    private PasswordChecker passwordChecker;
    private Scene currentScene;


    void Awake()
    {
        currentScene = SceneManager.GetActiveScene();
        passwordRequirements = GameObject.Find("PasswordRequirements");
        passwordChecker = GameObject.Find("Canvas").GetComponent<PasswordChecker>();
    }

    void Update()
    {
        if(currentScene.name == "ScrumMaster") // If the current scene is the password challenge, it runs the method CheckIsFirstAttempt()
        {
            CheckIsFirstAttempt();
        }
    }

    void CheckIsFirstAttempt() 
    {
        if (!SaveBooleans.IsFirstAttempt)
        {
            passwordRequirements.SetActive(true);
        }
        else
        {
            passwordRequirements.SetActive(false);
        }
    }
    public void CheckSaveBooleans() // Executes only when the button is pressed
    {
        if (passwordChecker.PasswordStrength == 5)
        {
            SaveBooleans.IsSuccessful = true;
            SaveBooleans.IsFirstAttempt = false;
        } else 
        {
            SaveBooleans.IsSuccessful = false;
            SaveBooleans.IsFirstAttempt = false;
        }
    }
}
