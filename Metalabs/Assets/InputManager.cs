using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;
    public PlayerInput _playerinput;

    private void Awake()
    {
        _playerinput = GetComponent<PlayerInput>();
    }


}
