using System.Collections;
using System.Collections.Generic;
using Autohand;
using UnityEngine;

public class PlayerTeleporter : MonoBehaviour
{
    [SerializeField] private AutoHandPlayer player;
    [SerializeField] private GameObject trackerOffsets;
    [SerializeField] private Scaler scaler;
    [SerializeField] private Transform teleportationDestination;
    [SerializeField] private MeshCollider collider;
    
    public void Teleport()
    {
        scaler.isBig = false;
        //scaler.fade = true;

        player.maxMoveSpeed = 1f;
        collider.enabled = true;
        StartCoroutine(TeleportPlayer());
    }

    private IEnumerator TeleportPlayer()
    {
        yield return new WaitForSeconds(3);
        player.SetPosition(teleportationDestination.position);
    }
}
