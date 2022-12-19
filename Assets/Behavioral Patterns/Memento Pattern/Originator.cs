using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.MementoPattern
{
    public class Originator : MonoBehaviour
    {
        [SerializeField]
        private Caretaker _history;

        [SerializeField]
        private float _speed;

        [SerializeField]
        private float _health = 100;


        // Record Memento every second to accomplish
        private float _timer = 0f;
        private float _recordFrequency = 1.0f; // in seconds

        void Awake()
        {
            SaveHistory();
        }

        void Update()
        {
            // Move
            Vector3 newPosition = new Vector3(transform.position.x + (_speed * Time.deltaTime), 0, 0);
            transform.position = newPosition;
            _speed += 0.01f;

            // Save history every second
            _timer += Time.deltaTime;
            if (_timer >= _recordFrequency)
            {
                SaveHistory();
                _timer = 0;
            }
        }

        private void SaveHistory()
        {
            Debug.Log("Saving history");
            _history.Push(new Memento(transform.position, _health, _speed));
        }

        public void ExecuteRewind()
        {
            Debug.Log("Rewind history");

            Memento restoreState = _history.Pop();
            if (restoreState == null)
                return;
            
            // Animate the rewind!
            // Instead of a just a snap!
            transform.position = restoreState.GetPosition();
            _health = restoreState.GetHealth();
            _speed = restoreState.GetSpeed();

            // Depends on how u want rewind to work...
            _timer = 0;
            if (_history.GetMementoCount() == 0)
            {
                // Save initial state
                SaveHistory();
            }
        }
    }
}