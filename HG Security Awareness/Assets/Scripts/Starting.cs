using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Starting : MonoBehaviour
{

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

    public void Restart()
    {
            SceneManager.LoadScene("AssignmentPasswordSecurity");
    }
}
