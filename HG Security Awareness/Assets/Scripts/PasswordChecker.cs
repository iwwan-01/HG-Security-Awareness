using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class PasswordChecker : MonoBehaviour
{
    public ButtonText buttonText;
   public InputField passwordInputField;
    // Update is called once per frame
     public void CheckPassword()
    {
        string PasswordString = passwordInputField.text;
       
        if(PasswordString.Length < 8){
            buttonText.SetText("Your password is too short!");
            
        }
        else if(!PasswordString.Any(char.IsDigit)){
            buttonText.SetText("Your password must contain a digit!");
            
        }
         else if(!PasswordString.Any(char.IsLetter)){
            buttonText.SetText("Your password must contain a letter!");
           
        }
        else if(!PasswordString.Any(char.IsUpper)){
            buttonText.SetText("Your password must contain an uppercase letter!");
            
        }
        else if(!PasswordString.Any(char.IsSymbol) && !PasswordString.Any(char.IsPunctuation)){
            buttonText.SetText("Your password must contain a symbol!");
            
        }
        else{
            buttonText.SetText("Your password meets all the requriements!");
        }
       
        
    }
}
