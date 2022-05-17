using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(InputController))]

public class CharacterController : MonoBehaviour
{
    [SerializeField, Range(0.01f, 10f)]
    private float _moveSpeed = 5f;

    // references
    private Animator _animator;
    private InputController _inputController;
    [SerializeField]
    private float _rotationSpeed = 150f;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _inputController = GetComponent<InputController>();
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * _moveSpeed * _inputController.Direction3D.magnitude * Time.deltaTime);

        if(_inputController.Direction3D.magnitude != 0f)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation,  Quaternion.LookRotation(_inputController.Direction3D), Time.deltaTime * _rotationSpeed);
        }
    }
    
    private void LateUpdate()
    {
        _animator.SetFloat("move", Mathf.Abs(_inputController.Direction3D.magnitude));
    }
}