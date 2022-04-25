using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class flyingMechanism : MonoBehaviour
{
    public float flyingForce = 2.4f;
    private new Rigidbody2D rigidbody;
    public bool isDead = false;
    public GameObject gameOver;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rigidbody.velocity = Vector2.up * flyingForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            isDead = true;
            gameOver.SetActive(true);
            pauseGame();  
        }
    }

    void pauseGame ()
    {
        Time.timeScale = 0;
    }
    
}
