using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbarscript : MonoBehaviour
{

    public Slider slider;

    [SerializeField] GameObject plusTwenty;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    
    public void SetHealth(int health)
    {
        slider.value = health;
    }

    private void Awake()
    {
        SetHealth(80);
        SetMaxHealth(100);
    }

    private void Update()
    {
        ExampleCourotine();
    }

    IEnumerator ExampleCourotine()
    {
        yield return new WaitForSeconds(.2f);

        plusTwenty.SetActive(false);
    }
}
