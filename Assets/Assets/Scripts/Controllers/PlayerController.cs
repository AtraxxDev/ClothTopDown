using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    private PlayerInteraction _playerInteraction;
    private PlayerAnimation _playerAnimation;

    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        _playerInteraction = GetComponent<PlayerInteraction>();
        _playerAnimation = GetComponent<PlayerAnimation>();
    }

    private void Update()
    {
        _playerMovement.ProcessInput();
        _playerInteraction.CheckInteractionInput();

        _playerAnimation.PlayDanceAnimation();
        


    }

    private void FixedUpdate()
    {
        
        _playerMovement.Move();
    }
}
