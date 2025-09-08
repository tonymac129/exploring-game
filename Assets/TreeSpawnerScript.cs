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

        Vector3 randomPosition = new Vector3(Random.Range(-25, 25), 0, Random.Range(-25, 25));
        Instantiate(currentgameObject, randomPosition, Quaternion.identity);
    }

}
