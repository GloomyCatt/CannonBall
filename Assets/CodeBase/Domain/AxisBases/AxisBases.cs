using Domain.AxisBases;
using UnityEngine;

namespace Domain.AxisBases
{
    public class AxisBases : AbstractAxisBases  
    {
        [SerializeField] private Transform _axis;
        [SerializeField] private Vector2 _current;
        [SerializeField] private float _speed;
        public Vector2 Current => _current;

        private void Awake()
        {
            Apply();
        }

        private void Apply()
        {
            _axis.rotation = Quaternion.Euler(_current.x, -_current.y, 0);
        }
        
        public override void Rotate(Vector2 vector)
        {
            _current += vector * _speed;
            Apply();
        }
    }
}
