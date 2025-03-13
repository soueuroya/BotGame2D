using UnityEngine;
using Platformer.Mechanics;

public class RotateWheel : MonoBehaviour
{
    [SerializeField]
    private PlayerController controller;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(-controller.velocity.x);
        transform.Rotate(Vector3.forward, -controller.velocity.x);
    }
}
