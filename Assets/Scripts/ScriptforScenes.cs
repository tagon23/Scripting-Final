using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptforScenes : MonoBehaviour
{
    float maxhealth = 100f;
    float currentHealth = 0;

    [SerializeField] GameObject defenem;
    [SerializeField] GameObject confenem;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    private void Awake()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(1);
        }else if (Input.GetKeyDown(KeyCode.K))
        {
            SceneManager.LoadScene(2);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("default"))
        {
           SceneManager.LoadScene(2);
        }else if (other.gameObject.CompareTag("confused"))
        {
            SceneManager.LoadScene(1);
        }
    }
}
