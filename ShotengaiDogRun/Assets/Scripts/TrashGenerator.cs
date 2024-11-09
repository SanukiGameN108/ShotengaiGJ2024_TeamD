using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabs;
    [SerializeField] private Vector3 spawnPosition = new Vector3(0, 0, 0);

    void Start()
    {
        GenerateTrash();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateTrash()
    {
        if (prefabs.Length == 0)
        {
            Debug.LogWarning("Prefabが割り当てられていません！");
            return;
        }

        // ランダムにprefab配列のインデックスを選択
        int randomIndex = Random.Range(0, prefabs.Length);

        GameObject selectedPrefab = prefabs[randomIndex]; // 選ばれたPrefab

        // 選ばれたPrefabを生成
        if (selectedPrefab != null)
        {
            Instantiate(selectedPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
