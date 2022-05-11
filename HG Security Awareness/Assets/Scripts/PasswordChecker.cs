using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class PasswordChecker : MonoBehaviour
{
   public ButtonText buttonText;
   public InputField passwordInputField;
    public Text lengthtext;
    public Text digittext;
    public Text lettertext;
    public Text uppercasetext;
    public Text symboltext;

    // Update is called once per frame
    //  public void CheckPassword()
    // {
    //     string PasswordString = passwordInputField.text;
       
    //     if(PasswordString.Length < 8){
    //         buttonText.SetText("Your password is too short!");
            
    //     }
    //     else if(!PasswordString.Any(char.IsDigit)){
    //         buttonText.SetText("Your password must contain a digit!");
            
    //     }
    //      else if(!PasswordString.Any(char.IsLetter)){
    //         buttonText.SetText("Your password must contain a letter!");
           
    //     }
    //     else if(!PasswordString.Any(char.IsUpper)){
    //         buttonText.SetText("Your password must contain an uppercase letter!");
            
    //     }
    //     else if(!PasswordString.Any(char.IsSymbol) && !PasswordString.Any(char.IsPunctuation)){
    //         buttonText.SetText("Your password must contain a symbol!");
            
    //     }
    //     else{
    //         buttonText.SetText("Your password meets all the requriements!");
    //     }
       
        
    // }
     private void Update() {
        
        string PasswordString = passwordInputField.text;
       
        if(PasswordString.Length < 8){
            //buttonText.SetText("Your password is too short!");
            lengthtext.color = Color.grey;
        }else{
            lengthtext.color = Color.black;
        }
        if(!PasswordString.Any(char.IsDigit)){
            //buttonText.SetText("Your password must contain a digit!");
            digittext.color = Color.grey;
        }
        else{
            digittext.color = Color.black;
        }
        if(!PasswordString.Any(char.IsLetter)){
            //buttonText.SetText("Your password must contain a letter!");
           lettertext.color = Color.grey;
        }
        else{
            lettertext.color = Color.black;
        }
        if(!PasswordString.Any(char.IsUpper)){
            //buttonText.SetText("Your password must contain an uppercase letter!");
            uppercasetext.color = Color.grey;
        }
        else{
            uppercasetext.color = Color.black;
        }
        if(!PasswordString.Any(char.IsSymbol) && !PasswordString.Any(char.IsPunctuation)){
            //buttonText.SetText("Your password must contain a symbol!");
            symboltext.color = Color.grey;
        }
        else{
            symboltext.color = Color.black;
        }
        
        
        
        
        // else{
        //     buttonText.SetText("Your password meets all the requriements!");
        // }
}
}
