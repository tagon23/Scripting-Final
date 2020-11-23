using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyScript : MonoBehaviour
{
    [SerializeField] GameObject defaultEnemy;
    [SerializeField] GameObject confusedEnemy;
    [SerializeField] BoxCollider defaultCollider;
    [SerializeField] BoxCollider confusedCollider;
    [SerializeField] Transform playerTransform;
    [SerializeField] Transform enemy;
    [SerializeField] ParticleSystem hit;
    [SerializeField] AudioClip thonk;

    public float distTobe = 100f;

    private IEnumerator coroutine1;
    

    private void Start()
    {
        //making sure everything is active at the start
        confusedEnemy.SetActive(false);
        defaultEnemy.SetActive(true);
        defaultCollider.enabled = true;
        confusedCollider.enabled = false;
    }


    private void Update()
    {
        enemyConfuse();
    }

    //if the player "attacks the enemy", then do the confused enemy thing
    public void enemyConfuse()
    {
        if (Vector3.Distance(playerTransform.position, enemy.position) <= distTobe)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                
                coroutine1 = EnemyCountdown(3f);
                StartCoroutine(coroutine1);
            }

            
        }
            
    }   

    public IEnumerator EnemyCountdown(float waitTime)
    {
        yield return new WaitForSeconds(1.5f);
        //play audio
        Audiocontroller.PlayClip2D(thonk, 4);

        //play particle
        hit.Play();

        //switch "models"
        defaultEnemy.SetActive(false);
        confusedEnemy.SetActive(true);
        defaultCollider.enabled = false;
        confusedCollider.enabled = true;

        //wait for 3ish seconds before switching back
        yield return new WaitForSeconds(waitTime);
        defaultEnemy.SetActive(true);
        confusedEnemy.SetActive(false);
        defaultCollider.enabled = true;
        confusedCollider.enabled = false;
    }
    
}
