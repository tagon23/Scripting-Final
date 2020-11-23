using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbarscript : MonoBehaviour
{

    public Slider slider;
    float health;

    [SerializeField] GameObject plusTwenty;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = 100;
        slider.value = 80;
    }

    private void Awake()
    {
        health = 80;
        SetMaxHealth(100);
    }

    private void Update()
    {
        if(health <= 100)
        {
            slider.value += .2f;
            health += .2f;
            plusTwenty.SetActive(true);
        }
        if(health == 100)
        {
            plusTwenty.SetActive(false);
        }
    }


}
