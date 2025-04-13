using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int speed = 5;
    
    Vector3 Up = new Vector3(0, 1, 0); 
    Vector3 Down = new Vector3(0, -1, 0); 
    Vector3 Right = new Vector3(1, 0, 0); 
    Vector3 Left = new Vector3(-1, 0, 0); 
    
    void Start()
    {
        
    }

    void Update()
    {
        UpdateMovement();
        UpdateShoot();
    }

    void UpdateMovement()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Up * Time.deltaTime * speed);
        }
        
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Down * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Left * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Right * Time.deltaTime * speed);
        }
    }

    void UpdateShoot()
    {
        if (Input.GetKey(KeyCode.Space))
            Debug.Log("Shoot");
    }
}
