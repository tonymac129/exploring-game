using UnityEngine;

public class TreeSpawnerScript : MonoBehaviour
{
    public GameObject treePrefab, rockPrefab;
    void Start()
    {

        for (int i = 0; i < 70; i++)
        {
            clone(treePrefab);
            clone(rockPrefab);
        }
    }
    void clone(GameObject currentgameObject)
    {
        int y;
        if (currentgameObject.name=="Rock")
        {
            y = -21;
        } else
        {
            y = -12;
        }
        Vector3 randomPosition = new Vector3(Random.Range(-25, 25), y, Random.Range(-25, 25));
        Instantiate(currentgameObject, randomPosition, Quaternion.identity);
    }

}
