using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class KillScript : MonoBehaviour
{
    private PlayerMovement PlayerMovement;

    void Start()
    {
        PlayerMovement = GetComponent<PlayerMovement>();       
    }

   void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "enemy")
        {
            PlayerMovement.moveSpeed = 0;
          SceneManager.LoadScene("DeathScene");
        }
    }

}
