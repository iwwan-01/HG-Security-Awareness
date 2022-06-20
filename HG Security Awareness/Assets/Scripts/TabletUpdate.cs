using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabletUpdate : MonoBehaviour
{
    // static TabletUpdate instance;
    private GameObject tabletImage;
    private Renderer tabletRenderer;

    public Material firstAttemptImage;
    public Material secondAttemptImage;
    public Material finalAttemptImage;

    // Start is called before the first frame update
    void Awake()
    {
        tabletImage = GameObject.Find("WhatsappImage");
        tabletRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        */

        if (SaveBooleans.IsFirstAssignment)
        {
            if (!SaveBooleans.IsFirstAttempt)
            {
                if (SaveBooleans.IsSuccessful == true)
                {
                    tabletRenderer.material = secondAttemptImage;
                }
                else if (SaveBooleans.IsSuccessful == false)
                {
                    tabletRenderer.material = finalAttemptImage;
                }
            }
            else
            {
                tabletRenderer.material = firstAttemptImage; 
            }
        } else
        {
            Destroy(gameObject);
        }
        
    }
}
