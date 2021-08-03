using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public GameObject _player;
    private bool _fps = false;
    public Vector3 _3rdOffset;
    public Vector3 _1stOffset;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = _3rdOffset; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (_fps)
            {
                transform.position = _3rdOffset;
                _fps = false;
            }
            else
            {
                transform.position = _1stOffset;
                _fps = true;
            }
        }   

    }

    private void LateUpdate()
    {
        transform.rotation = _player.transform.rotation;
        if (!_fps)
        {
            transform.LookAt(_player.transform.position);
        }
    }
}
