using System.Linq;
using UnityEngine;

namespace OneHourJam386
{
    public class Flag : MonoBehaviour
    {
        [SerializeField]
        private Material _goodFlag, _badFlag;

        public bool Didwin;

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
                Didwin = true;
                if (GameObject.FindGameObjectsWithTag("Flag").All(x => x.GetComponent<Flag>().Didwin))
                {
                    TankController.Instance.win.text = "You won";
                }
            }
            else if (other.CompareTag("Enemy"))
            {
                _renderer.material = _badFlag;
                Didwin = false;
            }
        }
    }
}
