using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Healthbar : MonoBehaviour
{
    public Slider slider;

    public void setMaxHealth(float health) { 
        slider.maxValue = health;
        slider.value = health;
    }

    public void setHealth(float health) { 
        slider.value = health;
        if (health < 1) { 
            Destroy(gameObject);
        }
    }
}
