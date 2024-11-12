using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] trashPrefabs;

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

        for (int currentCount = 1; currentCount <= StageConstants.TRASH_COUNT; currentCount++)
        {
            float randomPosX = Random.Range(0, StageConstants.GROUND_X_COUNT);
            int randomIndex = Random.Range(0, trashPrefabs.Length);
            GameObject selectedPrefab = trashPrefabs[randomIndex];

            if (selectedPrefab != null)
            {
                Vector3 randomPosition = new Vector3(randomPosX, StageConstants.TRASH_POSITION.y, StageConstants.TRASH_POSITION.z);
                Quaternion rotation = Quaternion.Euler(-90, 0, 0);
                Instantiate(selectedPrefab, randomPosition, rotation);
            }
        }
    }
}
