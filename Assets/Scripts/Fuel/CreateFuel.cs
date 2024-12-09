using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFuel : MonoBehaviour
{
    [SerializeField] GameObject FuelBottle;
    
    [SerializeField] GameObject Veichle;

    [SerializeField] Vector2 CreateSpeed;
    [SerializeField] Vector2 xAxixLimitToCreate;
    private void Start()
    {
        StartCoroutine(FuelCreator());
    }
    private IEnumerator FuelCreator()
    {

        yield return new WaitForSeconds(Random.Range(CreateSpeed.x,CreateSpeed.y));
        Vector3 position= transform.position;

        position.x = Veichle.transform.position.x+ Random.Range(xAxixLimitToCreate.x, xAxixLimitToCreate.y);
        Instantiate(FuelBottle,position, Quaternion.identity);
        StartCoroutine(FuelCreator());
    }

   
}
