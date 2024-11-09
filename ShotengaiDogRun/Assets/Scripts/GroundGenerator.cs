using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    public GameObject groundCubePrefab;
    private static readonly Vector3 GROUND_CUBE_SCALE = new Vector3(1, 1, 1);
    private static readonly Vector3 INITIAL_POSITION = new Vector3(-20, -3, 0);
    private static readonly int GROUND_X_COUNT = 100;
    private static readonly int GROUND_Z_COUNT = 5;

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

        for (int x = 0; x < GROUND_X_COUNT; x++)
        {
            for (int z = 0; z < GROUND_Z_COUNT; z++)
            {
                GameObject ground = Instantiate(groundCubePrefab);
                ground.transform.localScale = GROUND_CUBE_SCALE;
                // 配置位置を計算して設定
                Vector3 position = INITIAL_POSITION + new Vector3(x * GROUND_CUBE_SCALE.x, 0, z * GROUND_CUBE_SCALE.z);
                ground.transform.position = position;
            }
        }
    }
}
