using UnityEngine;

namespace Domain.CannonBall.BallSource
{


    public abstract class AbstractBallSource : MonoBehaviour
    {
        
        public abstract Ball New();
    }

}
