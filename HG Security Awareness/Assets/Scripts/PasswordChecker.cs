using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class PasswordChecker : MonoBehaviour
{
   public ButtonText buttonText;
   public InputField passwordInputField;
    public Text lengthText;
    public Text digitText;
    public Text letterText;
    public Text uppercaseText;
    public Text symbolText;
    public GameObject slider;

    
     private void Update() {
        string PasswordString = passwordInputField.text;
        if(PasswordString.Length > 8)
        {
            lengthText.color = Color.black;
        }else
        {
            lengthText.color = Color.gray;
        }
        if(PasswordString.Any(char.IsDigit))
        {
            digitText.color = Color.black;
        }else
        {
            digitText.color = Color.gray;
        }
        if(PasswordString.Any(char.IsLetter))
        {
            letterText.color = Color.black;
        }else
        {
            letterText.color = Color.gray;
        }
        if(PasswordString.Any(char.IsUpper))
        {
            uppercaseText.color = Color.black;
        }else
        {
            uppercaseText.color = Color.gray;
        }
        if(PasswordString.Any(char.IsSymbol) || PasswordString.Any(char.IsPunctuation))
        {
            symbolText.color = Color.black;
        }else
        {
            symbolText.color = Color.gray;
        }
}
}
