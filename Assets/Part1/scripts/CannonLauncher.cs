using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonLauncher : MonoBehaviour
{
    public Rigidbody ballPrefab; // armatnia kula
    public Transform launchPosition; //miejsce skad chcemy wystrzelic
    public float force; //sila
    public float destroyDelay; // czas po ktorym kula sie zniszczy

    private void OnMouseDown()
    {
        Rigidbody cannonBall = Instantiate(ballPrefab, launchPosition.transform.position, launchPosition.transform.rotation);
        cannonBall.AddForce(launchPosition.forward * force, ForceMode.Impulse);
        Destroy(cannonBall.gameObject, destroyDelay);
    }
}
