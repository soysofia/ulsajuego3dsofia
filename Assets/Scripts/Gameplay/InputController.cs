using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
   
    private GameInputs _gameInputs;

    private void Awake()
    {
        _gameInputs = new GameInputs();
    }
    private void OnEnable()
    {
        _gameInputs.Enable();
    }

    private void OnDisable()
    {
        _gameInputs.Disable();
    }

    public Vector2 Direction => _gameInputs.Gameplay.Direction.ReadValue<Vector2>();
    public Vector3 Direction3D => new Vector3(Direction.x, 0f, Direction.y);

}
