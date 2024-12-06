using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class DriverDeathFromHeead : MonoBehaviour
{

   


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
        
            GameManager.Instance.GameOver();
        
        }
    }

   
}
