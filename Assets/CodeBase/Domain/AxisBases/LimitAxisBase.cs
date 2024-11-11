using Domain.AxisBases;
using System;
using UnityEngine;

namespace Domain.AxisBases
{
    public class LimitAxisBase : AbstractAxisBases
    {
        [SerializeField]
        private AbstractAxisBases origin;
        [SerializeField]
        private AxisBases axis;
        [Header("Limits")]
        [SerializeField]
        private Range vertical;

        public override void Rotate(Vector2 vector)
        {
            vector.y = vertical.In(axis.Current.y + vector.y) ? vector.y : 0;
            origin.Rotate(vector);
        }

        [Serializable]
        public struct Range
        {
            public float min;
            public float max;

            public bool In(float value)
            {
                return value >= min && value <= max;
            }
        }
    }
}