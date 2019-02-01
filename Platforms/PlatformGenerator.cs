using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    //public GameObject Platform;
    public Transform generationPoint;
    public float distanceBetween;
    public float distanceBetweenMax;
    public float distanceBetweenMin;
    public GameObject[] randomPlatforms;

    private int platformSelector;
   private float platformWidth = 2f;

    void Start()
    {
        //platformWidth = Platform.GetComponent<BoxCollider2D>().size.x;

    }

    void Update()
    {

        if(transform.position.x < generationPoint.position.x)
        {


            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);

            transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);

            platformSelector = Random.Range(0, randomPlatforms.Length);
            Instantiate(randomPlatforms[platformSelector], transform.position, transform.rotation);
        }
    }
}
