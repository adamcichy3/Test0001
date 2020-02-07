using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenSize = 16f;
    [SerializeField] float min = 1f;
    [SerializeField] float max = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {
        float mousePosition = Input.mousePosition.x / Screen.width *screenSize;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosition, min, max);
        transform.position = paddlePos;

    }
}
