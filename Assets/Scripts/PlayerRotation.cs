using UnityEngine;

public class PlayerRotation : MonoBehaviour
{

    [SerializeField] private float rotSpeed;

    private void Update()
    {
        transform.Rotate(Vector3.forward, rotSpeed * Time.deltaTime);
    }
}
