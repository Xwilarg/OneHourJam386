using UnityEngine;

namespace OneHourJam386
{
    public class Flag : MonoBehaviour
    {
        [SerializeField]
        private Material _goodFlag, _badFlag;

        private MeshRenderer _renderer;

        private void Awake()
        {
            _renderer = GetComponent<MeshRenderer>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                _renderer.material = _goodFlag;
            }
            else if (other.CompareTag("Enemy"))
            {
                _renderer.material = _badFlag;
            }
        }
    }
}
