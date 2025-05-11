using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private string ISWALK = "isWalk";
    private string DANCE_TRIGGER = "isDance";


    public void ChangeWalkAnimation(bool value)
    {
        animator.SetBool(ISWALK, value);
    }

    public void PlayDanceAnimation()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            animator.SetTrigger(DANCE_TRIGGER);
        }
    }

}
