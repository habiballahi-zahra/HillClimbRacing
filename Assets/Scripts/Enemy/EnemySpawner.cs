using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject Enemy;

    [SerializeField] GameObject Veichle;

    [SerializeField] Vector2 CreateSpeed;
    [SerializeField] Vector2 xAxixLimitToCreate;

    private void Start()
    {
        StartCoroutine(EnemySpawn());   
    }

    private IEnumerator EnemySpawn()
    {

        yield return new WaitForSeconds(Random.Range(CreateSpeed.x, CreateSpeed.y));
        Vector3 position = transform.position;

        position.x = Veichle.transform.position.x + Random.Range(xAxixLimitToCreate.x, xAxixLimitToCreate.y);
        Instantiate(Enemy, position, Quaternion.identity);
        StartCoroutine(EnemySpawn());
    }
}
