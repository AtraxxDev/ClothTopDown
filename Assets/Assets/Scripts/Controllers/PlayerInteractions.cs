using Sirenix.OdinInspector;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private LayerMask npcLayer;
    [ReadOnly,ShowInInspector]
    private bool canInteract = false;
    private NPCInteraction currentNPC;

    public void CheckInteractionInput()
    {
        if (canInteract && Input.GetKeyDown(KeyCode.E))
        {
            if (currentNPC != null && !currentNPC.IsInteracting)
            {
                currentNPC.StartInteraction();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (((1 << other.gameObject.layer) & npcLayer) != 0)
        {
            canInteract = true;
            currentNPC = other.GetComponent<NPCInteraction>();
            currentNPC.ShowPrompt(true);
        }   
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (((1 << other.gameObject.layer) & npcLayer) != 0)
        {
            canInteract = false;
            currentNPC.ShowPrompt(false);
            currentNPC.EndInteraction();
            currentNPC = null;
        }
    }
}
