using UnityEngine;
using UnityEngine.InputSystem;

namespace OneHourJam386
{
    public class TankController : MonoBehaviour
    {
        private Rigidbody _rb;
        private const float _speed = 4f;
        private const float _rotSpeed = .5f;

        private Vector3 _mov;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            _rb.velocity = transform.forward * _mov.y * _speed;
            transform.Rotate(Vector3.up, _mov.x * _rotSpeed);
        }

        public void Move(InputAction.CallbackContext value)
        {
            _mov = value.ReadValue<Vector2>();
        }
    }
}