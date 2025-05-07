using UnityEngine;

public class PassiveNPC : NPCInteraction
{
    public override void StartInteraction()
    {
        base.StartInteraction();
        Debug.Log("Interactue con el NPC pasivo " + gameObject.name);
    }

    public override void EndInteraction()
    {
        base.EndInteraction();
        Debug.Log("Deje de Interactuar con el NPC pasivo " + gameObject.name);

    }
}
