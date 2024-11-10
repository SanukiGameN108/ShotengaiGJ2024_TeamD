using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] dogPrefabs;
    private static readonly Vector3 initialPosition = new Vector3(4, 0, 0);

    void Start()
    {
        GenerateDog();
    }

    void GenerateDog()
{
    if (dogPrefabs == null || dogPrefabs.Length == 0)
    {
        Debug.LogWarning("DogGeneratorにPrefabが割り当てられていません！");
        return;
    }

    int randomIndex = Random.Range(0, dogPrefabs.Length);
    GameObject selectedDogPrefab = dogPrefabs[randomIndex];
    Quaternion rotation = Quaternion.Euler(0, 90, 0);
    GameObject dogInstance = Instantiate(selectedDogPrefab, initialPosition, rotation);
    dogInstance.transform.localScale *= 2;
}

}
