using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] trashPrefabs;
    private static readonly Vector3 initialPosition = new Vector3(0, -2, 0);
    private static readonly int TRASH_COUNT = 10;  // 生成するゴミの数

    void Start()
    {
        GenerateTrash();
    }

    void GenerateTrash()
    {
        if (trashPrefabs.Length == 0)
        {
            Debug.LogWarning("TrashGeneratorにPrefabが割り当てられていません！");
            return;
        }

        for (int currentCount = 1; currentCount <= TRASH_COUNT; currentCount++)
        {
            float randomPosX = Random.Range(0, StageConstants.GROUND_X_COUNT);
            int randomIndex = Random.Range(0, trashPrefabs.Length);
            GameObject selectedPrefab = trashPrefabs[randomIndex];

            if (selectedPrefab != null)
            {
                Vector3 randomPosition = new Vector3(randomPosX, initialPosition.y, initialPosition.z);
                Quaternion rotation = Quaternion.Euler(-90, 0, 0);
                Instantiate(selectedPrefab, randomPosition, rotation);
            }
        }
    }
}
