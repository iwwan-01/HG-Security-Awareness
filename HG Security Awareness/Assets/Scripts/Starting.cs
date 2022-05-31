using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Starting : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("StartingScreen");
    }
    public void Mailbox()
    {
        SceneManager.LoadScene("Mailbox");
    }
    public void RightChoice()
    {
        SceneManager.LoadScene("RealEmail");
    }
    public void WrongChoice(){
        SceneManager.LoadScene("FakeEmail");
    }
    public void Inbox(){
        SceneManager.LoadScene("Mailbox");
    }
    public void RealChanger(){
        SceneManager.LoadScene("RealChanger");
    }
    public void FakeChanger(){
        SceneManager.LoadScene("FakeChanger");
    }
    public void Hacked(){
        SceneManager.LoadScene("Hacked");
    }

}
