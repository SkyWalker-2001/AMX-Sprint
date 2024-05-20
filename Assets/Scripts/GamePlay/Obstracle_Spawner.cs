using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Obstracle_Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] obstracle_Prefabs;

    public float spawnRate = 2f;
    public float Min_spawnRate = 2f;
    public float Max_spawnRate = 3f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn_Obstracle), spawnRate, spawnRate);
    }


    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn_Obstracle));
    }

    private void Spawn_Obstracle()
    {
        GameObject obstracle = Instantiate(obstracle_Prefabs[Random.Range(0, obstracle_Prefabs.Length)], transform.position, Quaternion.identity);
        obstracle.gameObject.GetComponent<Obstracle>().move_Vector_X = Random.Range(-12, -9);
    }
}
