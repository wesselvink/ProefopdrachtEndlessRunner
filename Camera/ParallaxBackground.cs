using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    public Transform[] backgrounds;
    public float smoothing = 1;

  
    private float[] parallaxScales;
    private Transform cam;
    private Vector3 previousCamPos;
   


    void Awake()
    {
        cam = Camera.main.transform;
    }

    void Start()
    {
        previousCamPos = cam.position;

        

        parallaxScales = new float[backgrounds.Length];
        for (int i = 0; i <backgrounds.Length; i++)
        {
            parallaxScales[i] = backgrounds[i].position.z * -1;
        }
    }

    void Update()
    {
        for (int i = 0; i < backgrounds.Length; i++)
        {
            float parallax = (previousCamPos.x - cam.position.x) * parallaxScales[i];
            float backgroundTargetposX = backgrounds[i].position.x + parallax;

            Vector3 backgroundTargetPosX = new Vector3(backgroundTargetposX, backgrounds[i].position.y, backgrounds[i].position.z);

            backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundTargetPosX, smoothing * Time.deltaTime);
        }
        previousCamPos = cam.position;
    }
}
