using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    [SerializeField]
    private Slot slotPrefab;
    [SerializeField]
    private Pipe pipePrefab;

    [SerializeField]
    private int n = 10;

    private Slot[,] slots;
    
    private void InitializeSlots()
    {
        slots = new Slot[n, n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                slots[i, j] = Instantiate(slotPrefab, new Vector3(Slot.size * j - (n/2) * Slot.size, Slot.size * i - (n/2) * Slot.size, 0), Quaternion.identity);
    }

    void Awake()
    {
        InitializeSlots();
        Instantiate(pipePrefab);
    }
}
