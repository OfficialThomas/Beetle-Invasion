using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float _moveSpeed = 1;
    public float _rotationSpeed = 1;
    private CharacterController _characterController;

    // Start is called before the first frame update
    void Start()
    {
        //https://docs.unity3d.com/ScriptReference/Cursor-lockState.html
        Cursor.lockState = CursorLockMode.Confined;

        _characterController = GetComponent<CharacterController>();   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * _rotationSpeed * Time.deltaTime, 0));
        Vector3 newPosition = transform.forward * Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime + transform.right * Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
        _characterController.SimpleMove(newPosition);
    }
}
