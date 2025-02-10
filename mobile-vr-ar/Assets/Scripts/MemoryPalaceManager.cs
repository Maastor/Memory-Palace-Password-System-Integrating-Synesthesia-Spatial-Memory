using UnityEngine;

public class MemoryPalaceManager : MonoBehaviour
{
    public GameObject roomPrefab;

    void Start()
    {
        Instantiate(roomPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
