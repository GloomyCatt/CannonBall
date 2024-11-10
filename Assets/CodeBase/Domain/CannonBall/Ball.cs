using UnityEngine;

namespace Domain.CannonBall
{
    [RequireComponent(typeof(Rigidbody))]
    public class Ball : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody _body;

        private void Awake()
        {
            _body = GetComponent<Rigidbody>();
        }

        public void ApplyPower(Vector3 force)
        {
            _body.AddForce(force, ForceMode.VelocityChange);
        }

        private void OnEnable()
        {
            _body.velocity = Vector3.zero;
        }
    }
}
