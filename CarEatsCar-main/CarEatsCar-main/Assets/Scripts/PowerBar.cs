using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PowerBar : MonoBehaviour
{
    public Slider slider;

    public void setPowerUp(float up){
        slider.value = up;
    }

    public void setMinPowerup(float minUp){
        slider.value = minUp;
        slider.minValue = minUp;
    }
}
