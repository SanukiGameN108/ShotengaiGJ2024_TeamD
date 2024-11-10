using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalWallGenerator : MonoBehaviour
{
    [SerializeField] private GameObject goalWallPrefab;
    private static readonly Vector3 initialPosition = new Vector3(StageConstants.GROUND_X_COUNT, 0, 0);

    void Start()
    {
        GenerateGoalWall();
    }

    void GenerateGoalWall()
    {
        if (goalWallPrefab == null)
        {
            Debug.LogWarning("GoalWallGeneratorにPrefabが割り当てられていません！");
            return;
        }
        Quaternion rotation = Quaternion.Euler(0, 0, 0);
        Instantiate(goalWallPrefab, initialPosition, rotation);
    }
}
