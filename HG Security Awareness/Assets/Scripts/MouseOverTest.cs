using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseOverTest : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool mouseOver = false;
    public Animator popupboxanimator;
    void Update(){
        if(mouseOver == false){
            popupboxanimator.SetBool("pop", false);
        }
    }
     
    public void OnPointerEnter(PointerEventData eventData){
        mouseOver = true;
        popupboxanimator.SetBool("pop", true);
        Debug.Log("Mouse enter");
    }
    public void OnPointerExit(PointerEventData eventData){
        mouseOver = false;
        popupboxanimator.SetBool("pop", false);
        Debug.Log("MouseExit");
    }
    
}
