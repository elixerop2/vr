using UnityEngine;

public class GemCollectionManager : MonoBehaviour
{
    public int totalGems = 3;
    public int collectedGems = 0;

    public GemCounterUI counterUI;
    public DoorController doorController;

    void Start()
    {
        UpdateUI();
    }

    public void GemPlaced()
    {
        collectedGems++;

        if (collectedGems > totalGems)
        {
            collectedGems = totalGems;
        }

        UpdateUI();

        if (collectedGems == totalGems)
        {
            doorController.OpenDoors();
        }
    }

    public void GemRemoved()
    {
        collectedGems--;

        if (collectedGems < 0)
        {
            collectedGems = 0;
        }

        UpdateUI();
    }

    void UpdateUI()
    {
        counterUI.UpdateCounter(collectedGems, totalGems);
    }
}



