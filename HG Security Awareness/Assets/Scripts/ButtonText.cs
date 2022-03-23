using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonText : MonoBehaviour
{
    public Text passwordtext;
   public void SetText(string text){
       passwordtext.text = text;
   }
}
