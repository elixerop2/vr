using UnityEngine;

public class GemSpawnManager : MonoBehaviour
{
    public GameObject[] Gems;
    public Transform[] SpawnPoints;

    void Start()
    {
        SpawnGems();
    }

    void SpawnGems()
    {
        // Create a list of available spawn points
        System.Collections.Generic.List<Transform> availablePoints =
            new System.Collections.Generic.List<Transform>(SpawnPoints);

        for (int i = 0; i < Gems.Length; i++)
        {
            // Pick a random spawn point
            int randomIndex = Random.Range(0, availablePoints.Count);

            Transform selectedPoint = availablePoints[randomIndex];

            // Move the gem to that point
            Gems[i].transform.position = selectedPoint.position;
            Gems[i].transform.rotation = selectedPoint.rotation;

            // Make sure the gem is active
            Gems[i].SetActive(true);

            // Remove the selected point so another gem can't use it
            availablePoints.RemoveAt(randomIndex);
        }
    }
}
