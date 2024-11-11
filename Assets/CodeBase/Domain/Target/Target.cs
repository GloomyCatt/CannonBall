using UnityEngine;

namespace Domain.Target
{
    public class Target : AbstractTarget
    {
        private void OnCollisionEnter(UnityEngine.Collision collision)
        {
            hit.Invoke();

            if (collision.gameObject.name == "Ball")
            {              
                MeshRenderer renderer = GetComponent<MeshRenderer>();
                
                if (renderer != null)
                {                  
                    renderer.material.color = Random.ColorHSV();
                }
            }
        }
    }
}