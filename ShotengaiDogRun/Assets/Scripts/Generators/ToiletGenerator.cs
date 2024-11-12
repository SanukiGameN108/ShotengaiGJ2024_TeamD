using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ToiletGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] toiletPrefabs;

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

        int generatedCount = 0;

        while (generatedCount < StageConstants.TOILET_COUNT)
        {
            float randomPosX = Random.Range(0, StageConstants.GROUND_X_COUNT);

            // randomPosXが穴の位置リストに含まれていないかを確認
            bool isNotHollPosX = !StageConstants.hollPosXList.Contains((int)randomPosX);
            if (isNotHollPosX)
            {
                int randomIndex = Random.Range(0, toiletPrefabs.Length);
                GameObject selectedPrefab = toiletPrefabs[randomIndex];

                if (selectedPrefab != null)
                {
                    Vector3 randomPosition = new Vector3(randomPosX, StageConstants.TOILET_POSITION.y, StageConstants.TOILET_POSITION.z);
                    Quaternion rotation = Quaternion.Euler(0, 180, 0);
                    Instantiate(selectedPrefab, randomPosition, rotation);
                    generatedCount++;
                }
            }
        }
    }
}
