using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField] GameSaveManager gameSaveManager;
    Vector2 spawn;
    Rigidbody2D rb;
    public int lives;
    public int points;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spawn = rb.transform.position;
        lives = 3;
        points = 0;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (lives <= 0)
        {
            gameSaveManager.SaveToDisk();
            Camera.main.GetComponent<SceneHandler>().LoadGameOverScreen();
        }
        //Debug.Log(spawnPoint);
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            //ResetBallPosition(Camera.main.ScreenToWorldPoint(Mouse.current.position.value));
        }
    }

    public void ResetBallPosition()
    {
        rb.transform.position = spawn;
        rb.velocity = Vector2.zero;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Fatal")
        {
            lives--;
            ResetBallPosition();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
     //   Debug.Log(collision.collider.tag);


        if (collision.collider.tag == "Bumper")
        {
            Debug.Log(collision.collider.tag);
            points++;
            //GameTester.
        }
        if(collision.collider.tag == "Slingshot")
        {
            points += 5;
            Debug.Log(collision.collider.tag);
        }
    }
}
