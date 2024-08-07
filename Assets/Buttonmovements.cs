using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonmovements : MonoBehaviour
{
    [SerializeField] Alienmovements alienmovements; 
    private bool canMove = true;

    void Update()
    {
        if (canMove && alienmovements != null)
        {
            Vector3 placement = Vector3.zero;

            if (Input.GetKey(KeyCode.A))
            {
                placement.x = -1;
                Debug.Log("Moving Left");
            }
            if (Input.GetKey(KeyCode.D))
            {
                placement.x = 1;
                Debug.Log("Moving Right");
            }
            if (Input.GetKey(KeyCode.W))
            {
                placement.y = 1;
                Debug.Log("Moving Up");
            }
            if (Input.GetKey(KeyCode.S))
            {
                placement.y = -1;
                Debug.Log("Moving Down");
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                alienmovements.Jump();
            }

            if (placement != Vector3.zero)
            {
                alienmovements.PlayerShifts(placement); 
            }
        }
    }
}
