using UnityEngine;
using System.Collections.Generic;

public class Player : ChessCharacter
{
    void Start()
    {
        //AvailablePiecePowers.Add(PieceType.None);
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
            transform.Translate(MathConstants.Up * Time.deltaTime * Speed);
        }
        
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(MathConstants.Down * Time.deltaTime * Speed);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(MathConstants.Left * Time.deltaTime * Speed);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(MathConstants.Right * Time.deltaTime * Speed);
        }
    }

    void UpdateShoot()
    {
        if (Input.GetKey(KeyCode.Space))
            Debug.Log("Shoot");
    }
}
