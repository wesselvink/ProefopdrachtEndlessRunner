using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    public float backgroundSize;

    private Transform cameraTransform;
    private float viewZone = 10;
    private int leftIndex;
    private int rightIndex;
    private Transform[] layers;

    void Start()
    {
        cameraTransform = Camera.main.transform;
        layers = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
            layers[i] = transform.GetChild(i);

        leftIndex = 0;
        rightIndex = layers.Length - 1;
    }

    void ScrollLeft()
    {
        int lastLeft = leftIndex;
        layers[leftIndex].position = Vector3.right * (layers[rightIndex].position.x + backgroundSize);
        rightIndex = leftIndex;
        leftIndex++;
        if(leftIndex == layers.Length)
        {
            leftIndex = 0;
        }
    }
        void Update()
    {
        if(cameraTransform.position.x > (layers[rightIndex].transform.position.x - viewZone))
        {
            ScrollLeft();
        }
    }

}
