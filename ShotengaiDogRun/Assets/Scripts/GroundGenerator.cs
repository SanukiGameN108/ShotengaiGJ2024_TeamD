using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    public GameObject groundPrefab;
    private static readonly Vector3 GROUND_SCALE = new Vector3(100, 1, 5);
    private static readonly Vector3 GROUND_POSITION = new Vector3(0, -3, 0);

    void Start()
    {
        GenerateGround();
    }

    void GenerateGround()
    {
        if (groundPrefab != null)
        {
            GameObject ground = Instantiate(groundPrefab);
            ground.transform.localScale = GROUND_SCALE;
            ground.transform.position = GROUND_POSITION;
        }
        else
        {
            Debug.LogWarning("Ground Prefabが割り当てられていません。");
        }
    }
}
