using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnContact : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "Player")
        {
            Debug.Log("Got hit");
            /*isDead = true;
            gameOver.SetActive(true);*/
        }
    }
}
