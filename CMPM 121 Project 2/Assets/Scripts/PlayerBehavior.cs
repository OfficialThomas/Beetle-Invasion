using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float _moveSpeed = 1;
    private CharacterController _characterController;

    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();   
    }

    // Update is called once per frame
    void Update()
    {
        _characterController.SimpleMove(new Vector3(Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime, 0, Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime));
    }
}
