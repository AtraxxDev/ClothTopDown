using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private string ISWALK = "isWalk";


    public void ChangeWalkAnimation(bool value)
    {
        animator.SetBool(ISWALK, value);
    }
    
}
