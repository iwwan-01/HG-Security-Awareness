using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SignUpButton : MonoBehaviour
{
    private PasswordChecker passwordChecker;

    private void Awake()
    {
        passwordChecker = GameObject.Find("Canvas").GetComponent<PasswordChecker>();
    }
    public void OnButtonPressed()
    {
        if(passwordChecker.PasswordStrength == 5)
        {
            SaveBooleans.IsStrong = true;
            SceneManager.LoadScene("MainScreen");  
        }
        else
        {
            SaveBooleans.IsStrong = false;
            SceneManager.LoadScene("MainScreen"); 
        }

        if(passwordChecker.PasswordStrength < 5 && !SaveBooleans.IsFirstAttempt)
        {
            SaveBooleans.isSecondAttempt = true;
        }
    }
}
