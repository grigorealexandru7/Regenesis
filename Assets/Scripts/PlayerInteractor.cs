using UnityEngine;
using UnityEngine.InputSystem;
    public class PlayerInteractor : MonoBehaviour
    {
        [SerializeField] private Transform playerCamera;
        [SerializeField] private float interactionDistance;
        [SerializeField] private LayerMask  interactionLayer;
        [SerializeField] private InputActionReference interactReference;

        private void OnEnable()
        {
            interactReference.action.Enable();
            interactReference.action.started += PlayerInteracted;
        }

        private void OnDisable()
        {
            interactReference.action.started -= PlayerInteracted;
            interactReference.action.Disable();
        }

        void PlayerInteracted(InputAction.CallbackContext context)
        {
            Debug.Log("PlayerInteracted");
            if (context.started)
            {
                Ray ray = new Ray(playerCamera.position, playerCamera.forward);
                if (!Physics.Raycast(ray, out RaycastHit hitInfo, interactionDistance, interactionLayer, QueryTriggerInteraction.Collide)) return;
                Debug.DrawRay(playerCamera.position, playerCamera.forward, Color.red);
                if (!hitInfo.collider.gameObject.TryGetComponent(out IInteractable  interactableObject)) return;
                {
                    interactableObject.Interact();
                }
            }
        }
    }

