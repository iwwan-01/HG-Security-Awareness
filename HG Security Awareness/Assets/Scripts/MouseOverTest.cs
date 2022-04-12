using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseOverTest : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool hasPlayed;
    public Animator popupboxanimator;
    // void Update(){
    //     if(mouseOver == false){
    //         popupboxanimator.SetBool("pop", false);
    //     }
    // }
     
    public void OnPointerEnter(PointerEventData eventData){

        if (!hasPlayed)
        {
            hasPlayed = true;
            popupboxanimator.SetBool("pop", true);
            Debug.Log("Mouse enter");
        }
        else
            return;

    }
    public void OnPointerExit(PointerEventData eventData){
        popupboxanimator.SetBool("pop", false);
        Debug.Log("MouseExit");
    }
    
}
