using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TamadixGenerator : MonoBehaviour
{
    [SerializeField] private GameObject tamadixPrefab;
    private static readonly Vector3 initialPosition = new Vector3(0, 0, 0);

    void Start()
    {
        GenerateTamadix();
    }

    void GenerateTamadix()
    {
        if (tamadixPrefab == null)
        {
            Debug.LogWarning("TamadixGeneratorにPrefabが割り当てられていません！");
            return;
        }

        Instantiate(tamadixPrefab, initialPosition, Quaternion.identity);
    }
}
