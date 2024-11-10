using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogGenerator : MonoBehaviour
{
    [SerializeField] private GameObject dogPrefab;
    private static readonly Vector3 initialPosition = new Vector3(0, 0, 0);

    void Start()
    {
        GenerateDog();
    }

    void GenerateDog()
    {
        if (dogPrefab == null)
        {
            Debug.LogWarning("DogGeneratorにPrefabが割り当てられていません！");
            return;
        }

        Instantiate(dogPrefab, initialPosition, Quaternion.identity);
    }
}
