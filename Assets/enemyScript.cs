using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyScript : MonoBehaviour
{
    [SerializeField] GameObject defaultEnemy;
    [SerializeField] GameObject confusedEnemy;


    private void Awake()
    {
        confusedEnemy.SetActive(false);
        defaultEnemy.SetActive(true);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            defaultEnemy.SetActive(false);
            confusedEnemy.SetActive(true);
        }
    }

}
