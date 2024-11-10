using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Domain.CannonBall.BallSource
{
    public class ObjectPoolBallSources : AbstractBallSource
    {
        [SerializeField] private Ball _ballTemplate;
        [SerializeField] private float _ballLifeTime = 2f;

        private Queue<Ball> _balls = new();

        public override Ball New()
        {
            if (_balls.TryDequeue(out var newBall))
            {
                newBall.gameObject.SetActive(true);
            }
            else
            {
                newBall = Instantiate(_ballTemplate);
            }

            StartCoroutine(CountDown(newBall));
            return newBall;
        }

        private IEnumerator CountDown(Ball ball)
        {
            yield return new WaitForSeconds(_ballLifeTime);
            ball.gameObject.SetActive(false);
            _balls.Enqueue(ball);
        }
    }
}
