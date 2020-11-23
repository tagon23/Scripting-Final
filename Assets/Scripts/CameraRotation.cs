using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{

    [SerializeField] Transform cam;

    // Update is called once per frame
    void Update()
    {
        cam.transform.Translate(Vector3.right * Time.deltaTime);
    }
}
