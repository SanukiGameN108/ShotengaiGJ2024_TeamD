using UnityEngine;
using System.Linq;

public class ObstaclesGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaclesPrefabs;
    private static readonly Vector3 initialPosition = new Vector3(0, -2.5f, 0);
    private static readonly int OBSTACLES_COUNT = 10;  // 生成する障害物の数

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

        while (generatedCount < OBSTACLES_COUNT)
        {
            float randomPosX = Random.Range(0, StageConstants.GROUND_X_COUNT);

            bool isNotHollPosX = !StageConstants.hollPosXList.Contains((int)randomPosX);
            if (isNotHollPosX)
            {
                int randomIndex = Random.Range(0, obstaclesPrefabs.Length);
                GameObject selectedPrefab = obstaclesPrefabs[randomIndex];

                if (selectedPrefab != null)
                {
                    Vector3 randomPosition = new Vector3(randomPosX, initialPosition.y, initialPosition.z);
                    Quaternion rotation = Quaternion.Euler(0, 180, 0);
                    Instantiate(selectedPrefab, randomPosition, rotation);
                    generatedCount++;
                }
            }
        }
    }
}
