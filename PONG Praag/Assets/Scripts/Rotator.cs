using UnityEngine;
namespace Assets.Scripts
{
    class Rotator : MonoBehaviour
    {
        [SerializeField]
        private Vector3 _rotation;
        [SerializeField]
        private float _speed = 1f;
        private void Update()
        {
            this.transform.eulerAngles += this._rotation * Time.deltaTime * this._speed;
        }
    }
}
