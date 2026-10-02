
using TMPro;
using UnityEngine;

public class GemCounterUI : MonoBehaviour
{
    public TextMeshProUGUI counterText;

    public void UpdateCounter(int collected, int total)
    {
        counterText.text = "Gems: " + collected + "/" + total;
    }
}
