using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] toiletPrefabs;
    private static readonly Vector3 initialPosition = new Vector3(0, -2, 0);
    private static readonly int TOILET_COUNT = 10;

    void Start()
    {
        GenerateToilet();
    }

    void GenerateToilet()
    {
        if (toiletPrefabs.Length == 0)
        {
            Debug.LogWarning("ToiletGeneratorにPrefabが割り当てられていません！");
            return;
        }

        for (int currentCount = 1; currentCount <= TOILET_COUNT; currentCount++)
        {
            float randomPosX = Random.Range(0, StageConstants.GROUND_X_COUNT);
            int randomIndex = Random.Range(0, toiletPrefabs.Length);
            GameObject selectedPrefab = toiletPrefabs[randomIndex];

            if (selectedPrefab != null)
            {
                Vector3 randomPosition = new Vector3(randomPosX, initialPosition.y, initialPosition.z);
                Quaternion rotation = Quaternion.Euler(0, 180, 0);
                Instantiate(selectedPrefab, randomPosition, rotation);
            }
        }
    }
}
