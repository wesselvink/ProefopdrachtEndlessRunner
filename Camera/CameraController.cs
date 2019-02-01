using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public PlayerMovement player;

    private Vector3 lastPlayerPos;
    private float distanceMove;

    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
        lastPlayerPos = player.transform.position;
    }

    void LateUpdate()
    {
        distanceMove = player.transform.position.x - lastPlayerPos.x;

        transform.position = new Vector3(transform.position.x + distanceMove, transform.position.y, transform.position.z);


        lastPlayerPos = player.transform.position;
    }
}