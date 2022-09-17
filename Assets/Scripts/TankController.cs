using UnityEngine;
using UnityEngine.InputSystem;

namespace OneHourJam386
{
    public class TankController : MonoBehaviour
    {
        private Rigidbody _rb;
        private const float _speed = 8f;
        private const float _rotSpeed = 10f;

        private Vector3 _mov;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            var relMove = transform.up * _mov.y * _speed;
            _rb.velocity = new Vector3(relMove.x, _rb.velocity.y, relMove.z);
            _rb.angularVelocity = new Vector3(relMove.x, _mov.x * _rotSpeed, relMove.z);
        }

        public void Move(InputAction.CallbackContext value)
        {
            _mov = value.ReadValue<Vector2>();
        }
    }
}