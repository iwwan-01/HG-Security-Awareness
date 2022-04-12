using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PopUpSystem : MonoBehaviour
{
   public GameObject popUpBox;
   public Animator animator;
   public Text popUpText;

   public void PopUp(string text){
       popUpBox.SetActive(true);
       popUpText.text = text;
       animator.SetBool("pop", true);
   }
}
