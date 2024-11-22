using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BublleMaker : MonoBehaviour
{

    [SerializeField] private GameObject Bubble;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {

            Instantiate(Bubble, transform.position, Quaternion.identity);

           
        }
    }
}
