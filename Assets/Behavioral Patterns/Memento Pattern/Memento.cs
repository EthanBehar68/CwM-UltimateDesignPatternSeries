using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.MementoPattern
{
    public class Memento
    {
        private Vector3 _position;
        private float _health;
        private float _speed;

        public Memento(Vector3 position, float health, float speed)
        {
            _position = position;
            _health = health;
            _speed = speed;
        }

        public Vector3 GetPosition()
        {
            return _position;
        }

        public float GetHealth()
        {
            return _health;
        }

            public float GetSpeed()
        {
            return _speed;
        }
    }
}