using System.Collections;
using System.Collections.Generic;
using Autohand;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerTeleporter : MonoBehaviour
{
    [SerializeField] private AutoHandPlayer player;
    [SerializeField] private GameObject trackerOffsets;
    [SerializeField] private Scaler scaler;
    [SerializeField] private Transform teleportationDestination;
    [SerializeField] private MeshCollider collider;
    [SerializeField] private GridManager grid;

    public InputActionProperty Abutton;
    public InputActionProperty Bbutton;
    public InputActionProperty Xbutton;
    public InputActionProperty Ybutton;

    private void OnEnable() {
        if (Abutton.action != null) Abutton.action.Enable();
        if (Abutton.action != null) Abutton.action.performed += OnAbutton;
    }
    

    private IEnumerator TeleportPlayer() {
        yield return new WaitForSeconds(3);
    }

    private void OnAbutton(InputAction.CallbackContext a)
    {
        Fade();
        Invoke("Scale", scaler.fadeDuration);
        Invoke(scaler.isBig ? "SetSmallPosition" : "ResetPosition", scaler.duration + scaler.fadeDuration);
        Invoke("Unfade", scaler.fadeDuration + scaler.duration);
    }

    private void ResetPosition() {
        player.SetPosition(new Vector3(0f, 1f, 0f));
        player.maxMoveSpeed = 5;
        collider.enabled = false;
        grid.SetColliders(true);
    }

    private void SetSmallPosition() {
        player.SetPosition(teleportationDestination.position);
        player.maxMoveSpeed = .5f;
        collider.enabled = true;
        grid.SetColliders(false);
    }

    private void Fade()
    {
        scaler.fade = true;
    }

    private void Unfade()
    {
        scaler.fade = false;
    }

    private void Scale()
    {
        scaler.isBig = !scaler.isBig;
    }
}
