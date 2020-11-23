using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] Animator UnityCh;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //UnityCh.StopPlayback();
            UnityCh.Play("RUN00_F", -1, 0);
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.S))
        {
            UnityCh.StopPlayback();
            UnityCh.Play("WAIT00", -1, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            UnityCh.StopPlayback();
            UnityCh.Play("RUN00_R", -1, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            //UnityCh.StopPlayback();
            UnityCh.Play("RUN00_L", -1, 0);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            UnityCh.Play("WAIT04", -1, 0f);
            //UnityCh.Play("WAIT00", -1, 0f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            UnityCh.Play("WALK00_B");
        }
        
    }
}
