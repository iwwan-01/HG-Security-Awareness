using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableandEnable : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void WhenButtonClicked(){
        if(canvas.activeInHierarchy == true){
            canvas.SetActive(false);
        }else
        {
            canvas.SetActive(true);
        }
    }
}
