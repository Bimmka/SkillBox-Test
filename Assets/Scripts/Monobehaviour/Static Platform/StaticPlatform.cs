using UnityEngine;

[RequireComponent(typeof(BoxCollider)), RequireComponent(typeof(Rigidbody))]
public class StaticPlatform : MonoBehaviour
{
    private Rigidbody platformRigidbody;

    private void Awake()
    {
        TryGetComponent(out platformRigidbody);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Static Zone")) SetPlatformKinematic();
    }

    private void SetPlatformKinematic()
    {
        platformRigidbody.isKinematic = true;
    }
}
