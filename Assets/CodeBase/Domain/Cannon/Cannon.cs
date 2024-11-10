using Domain.CannonBall;
using Domain.CannonBall.BallSource;
using UnityEngine;

namespace Domain.Cannon
{
    public class Cannon : AbstractCannon
    {
        [SerializeField] private float _power;
        [SerializeField] private Transform _shootPoint;
        [SerializeField] private ObjectPoolBallSources _ballSource;

        public override void Shoot()
        {
            Ball ball = _ballSource.New();
            ball.transform.position = _shootPoint.position;
            ball.ApplyPower(_shootPoint.forward * _power);
        }
    }
}
