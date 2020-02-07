using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle1;
    [SerializeField] float xPush = 5f;
    [SerializeField] float yPush = 10f;
    bool hasStarted = false;
    Vector2 paddleToBallVector;
    void Start()
    {
        paddleToBallVector = transform.position - paddle1.transform.position; //offset
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            LockBall();
        }
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            GetComponent<Rigidbody>().velocity = new Vector2(xPush, yPush);
        }
      
    }

    private void LockBall()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }
}
