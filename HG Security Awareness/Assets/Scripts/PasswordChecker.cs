using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class PasswordChecker : MonoBehaviour
{
    public ButtonText buttonText;
    public InputField passwordInputField;
    public InputField referenceInput;
    public Image checkMarkImage;
    
    #region Object reference to the live time updated requirements
    public Text lengthText;
    public Text digitText;
    public Text letterText;
    public Text uppercaseText;
    public Text symbolText;
    #endregion
    
    public GameObject slider;
    public Color color;
    public Animator PasswordSliderAnimator;
    
    
    #region Variables for Password Strength Meter
    private int Length = 0;
    private int Digit = 0;
    private int Letter = 0;
    private int Uppercase = 0;
    private int Symbol = 0;
    public int PasswordStrength;
    #endregion

    
     private void Update() {
        string PasswordString = passwordInputField.text;
        PasswordStrength = Length + Digit + Letter + Uppercase + Symbol;
        if(PasswordString.Length > 8)
        {
            lengthText.color = Color.black;
            Length = 1;
        }else
        {
            lengthText.color = Color.gray;
            Length = 0;
        }
        if(PasswordString.Any(char.IsDigit))
        {
            digitText.color = Color.black;
            Digit = 1;
        }else
        {
            digitText.color = Color.gray;
            Digit = 0;
        }
        if(PasswordString.Any(char.IsLetter))
        {
            letterText.color = Color.black;
            Letter = 1;
        }else
        {
            letterText.color = Color.gray;
            Letter = 0;
        }
        if(PasswordString.Any(char.IsUpper))
        {
            uppercaseText.color = Color.black;
            Uppercase = 1;
        }else
        {
            uppercaseText.color = Color.gray;
            Uppercase = 0;
        }
        if(PasswordString.Any(char.IsSymbol) || PasswordString.Any(char.IsPunctuation))
        {
            symbolText.color = Color.black;
            Symbol = 1;
        }else
        {
            symbolText.color = Color.gray;
            Symbol = 0;
        }
        if(PasswordStrength >= 2){
            PasswordSliderAnimator.SetBool("PassWeak", true);
        }else{
            PasswordSliderAnimator.SetBool("PassWeak", false);
            
        }
        if(PasswordStrength >= 4){
            PasswordSliderAnimator.SetBool("PassAverage", true);
        }else{
            PasswordSliderAnimator.SetBool("PassAverage", false);
            
        }
        if(PasswordStrength == 5){
            PasswordSliderAnimator.SetBool("PassStrong", true);
            
        }else{
            PasswordSliderAnimator.SetBool("PassStrong", false);
            
        }
        if(referenceInput.text == "413669"){
            checkMarkImage.gameObject.SetActive(true);
        }else{
            checkMarkImage.gameObject.SetActive(false);
        }

}
}
