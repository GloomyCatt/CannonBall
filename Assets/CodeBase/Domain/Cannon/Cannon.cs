using Domain.CannonBall;
using UnityEngine;

namespace Domain.Cannon
{
    public class Cannon : AbstractCannon
    {
        [SerializeField] private float _power;
        [SerializeField] private Transform _shootPoint;
        [SerializeField] private Ball _ballSource;

        public override void Shoot()
        {
            Ball ball = Instantiate(_ballSource, _shootPoint);
            ball.transform.position = _shootPoint.position;
            ball.ApplyPower(_shootPoint.forward * _power);
        }
    }
}
