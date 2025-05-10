using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    private PlayerInteraction _playerInteraction;

    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        _playerInteraction = GetComponent<PlayerInteraction>();
    }

    private void Update()
    {
        _playerMovement.ProcessInput();
        _playerInteraction.CheckInteractionInput();
    }

    private void FixedUpdate()
    {
        
        _playerMovement.Move();
    }
}
