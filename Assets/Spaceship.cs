using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<Alienmovements>() != null)
        {
            other.GetComponent<Alienmovements>().GetPoint();
            Destroy(this.gameObject);
        }
    }
}
