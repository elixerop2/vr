using UnityEngine;

public class ExitTrigger : MonoBehaviour
{
    public GameObject gameCompletionUI;

    private void OnTriggerEnter(Collider other)
    {
        gameCompletionUI.SetActive(true);
    }
}
