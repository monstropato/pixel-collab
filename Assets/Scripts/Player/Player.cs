using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerCollision))]
[RequireComponent(typeof(PlayerAnimation))]
public class Player : MonoBehaviour
{
    //CACHED CLASSES REFERENCES
    internal PlayerInput playerInput;
    internal PlayerMovement playerMovement;
    internal PlayerCollision playerCollision;
    internal PlayerAnimation playerAnimation;

    void Start()
    {
        GetCachedReferences();
        StartCustomStarts();
    }

    internal void GetCachedReferences()
    {
        playerInput = GetComponent<PlayerInput>();
        playerMovement = GetComponent<PlayerMovement>();
        playerCollision = GetComponent<PlayerCollision>();
        playerAnimation = GetComponent<PlayerAnimation>();
    }

    internal void StartCustomStarts()
    {
        playerInput.CustomStart();
        playerMovement.CustomStart();
        playerCollision.CustomStart();
        playerAnimation.CustomStart();
    }
}
