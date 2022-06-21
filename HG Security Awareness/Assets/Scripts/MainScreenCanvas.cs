using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScreenCanvas : MonoBehaviour
{
    public static bool hasRead;
    public Canvas DescriptionCanvas;
    // Start is called before the first frame update
    void Start()
    {
        if(hasRead == true){
            DescriptionCanvas.gameObject.SetActive(false);
        }
    }
    public void CheckMarkClicked(){
        hasRead = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
