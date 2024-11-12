using UnityEngine;
using System.Linq;

public class ObstaclesGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaclesPrefabs;

    void Start()
    {
        GenerateObstacles();
    }

    void GenerateObstacles()
    {
        if (obstaclesPrefabs.Length == 0)
        {
            Debug.LogWarning("ObstaclesGeneratorにPrefabが割り当てられていません！");
            return;
        }

        int generatedCount = 0;

        while (generatedCount < StageConstants.OBSTACLES_COUNT)
        {
            float randomPosX = Random.Range(0, StageConstants.GROUND_X_COUNT);

            bool isNotHollPosX = !StageConstants.hollPosXList.Contains((int)randomPosX);
            if (isNotHollPosX)
            {
                int randomIndex = Random.Range(0, obstaclesPrefabs.Length);
                GameObject selectedPrefab = obstaclesPrefabs[randomIndex];

                if (selectedPrefab != null)
                {
                    Vector3 randomPosition = new Vector3(randomPosX, StageConstants.OBSTACLES_POSITION.y, StageConstants.OBSTACLES_POSITION.z);
                    Quaternion rotation = Quaternion.Euler(0, 180, 0);
                    Instantiate(selectedPrefab, randomPosition, rotation);
                    generatedCount++;
                }
            }
        }
    }
}
