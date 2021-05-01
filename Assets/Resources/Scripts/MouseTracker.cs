using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTracker : MonoBehaviour
{
    public Camera mainCam;      // Main Camera
    public GameObject clickVFX; // Click Visual FX
    
    void Update()
    {
        Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit)) {
            transform.position = hit.point;

            if (Input.GetMouseButtonDown(0))
            {
                clickVFX.transform.position = hit.point;
                clickVFX.GetComponent<ParticleSystem>().Play();
            }
            else
            {
                clickVFX.GetComponent<ParticleSystem>().Stop();
            }
        }
    }
}
