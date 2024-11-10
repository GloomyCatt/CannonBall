using Domain.AxisBases;
using Domain.Cannon;
using UnityEngine;

namespace Domain.PlayerInput
{
    public class PlayerInputs : MonoBehaviour
    {
        [SerializeField]
        private AbstractCannon _cannon;
        [SerializeField]
        private AbstractAxisBases _axisBase;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _cannon.Shoot();
            }

            var input = new Vector2(UnityEngine.Input.GetAxis("Vertical"), UnityEngine.Input.GetAxis("Horizontal"));
            _axisBase.Rotate(input * Time.deltaTime);
        }
    }
}
