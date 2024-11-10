using UnityEngine;
using UnityEngine.Events;

namespace Domain.Target
{
    public class AbstractTarget : MonoBehaviour
    {
        public UnityEvent hit = new();
    }
}