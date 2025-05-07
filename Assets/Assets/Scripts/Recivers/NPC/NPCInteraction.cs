using Sirenix.OdinInspector;
using UnityEngine;

public abstract class NPCInteraction : MonoBehaviour
{
    [SerializeField] private GameObject promptUI;
    private bool isInteracting;
    public bool IsInteracting => isInteracting;

    public void ShowPrompt(bool show)
    {
        promptUI.SetActive(show);
    }

    [Button]
    public virtual void StartInteraction()
    {
        isInteracting = true;
        Debug.Log("Interacción iniciada");
    }

    public virtual void EndInteraction()
    {
        isInteracting = false;
        Debug.Log("Interacción terminada");
    }
}
