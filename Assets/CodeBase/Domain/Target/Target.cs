using UnityEngine;

namespace Domain.Target
{
    public class Target : AbstractTarget
    {
        private void OnCollisionEnter(UnityEngine.Collision collision)
        {
            hit.Invoke();
        }
    }
}