using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    public GameObject groundCubePrefab;
    void Start()
    {
        GenerateGround();
    }

    void GenerateGround()
    {
        if (groundCubePrefab == null)
        {
            Debug.LogWarning("Ground Prefabが割り当てられていません。");
            return;
        }

        for (int x = 0; x < StageConstants.GROUND_X_COUNT; x++)
        {
            for (int y = 0; y < StageConstants.GROUND_Y_COUNT; y++)
            {
                for (int z = 0; z < StageConstants.GROUND_Z_COUNT; z++)
            {
                GameObject ground = Instantiate(groundCubePrefab);
                Vector3 groundCubeScale = StageConstants.GROUND_CUBE_SCALE;
                ground.transform.localScale = groundCubeScale;
                // 配置位置を計算して設定
                Vector3 diffPosition = new Vector3(x * groundCubeScale.x, y * groundCubeScale.y, z * groundCubeScale.z);
                Vector3 position = StageConstants.INITIAL_POSITION + diffPosition;
                ground.transform.position = position;
            }
            }
        }
    }
}
