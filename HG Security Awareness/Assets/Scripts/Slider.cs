using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{
    public PasswordChecker passwordChecker;
    public Slider slider;
    public float red;
    public float orange;
    public float green;
    public Color sliderColor;

    public void UpdateRed(float newRed)
    {
        red = newRed;
        UpdateSliderColor();
    }
    public void UpdateOrange(float newOrange)
    {
        orange = newOrange;
        UpdateSliderColor();
    }
    public void UpdateGreen(float newGreen)
    {
        green = newGreen;
        UpdateSliderColor();
    }

    public void UpdateSliderColor()
    {
        sliderColor = new Color(red, orange, green);
    }
}
