using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Starting : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("AssignmentPasswordSecurity");
    }

    public void ToStartingScreen()
    {
        SceneManager.LoadScene("StartingScreen");
    }

    public void ToMailBox()
    {
        SceneManager.LoadScene("MailBox");
    }

    public void ToFakeEmail()
    {
        SceneManager.LoadScene("FakeEmail");
    }

    public void ToRealEmail()
    {
        SceneManager.LoadScene("RealEmail");
    }

    public void ToFakeChangePassword()
    {
        SceneManager.LoadScene("FakeChangePassword");
    }

    public void ToRealChangePassword()
    {
        SceneManager.LoadScene("RealChangePassword");
    }

    public void FromMailToInbox()
    {
        SceneManager.LoadScene("MailBox");

    }

    public void ToHacked()
    {
        SceneManager.LoadScene("Hacked");
    }
    public void InternetExplorer(){
        SceneManager.LoadScene("InternetExplorer");
    }

    public void Restart()
    {
        SceneManager.LoadScene("AssignmentPasswordSecurity");
    }

    public void ToOptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void ToStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Quiting game...");
        Application.Quit();
    }
}
