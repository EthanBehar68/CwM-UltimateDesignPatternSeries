using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.StatePattern
{
    public class  PhotoshopCanvas : MonoBehaviour
    {
        [SerializeField]
        private PhotoshopCursor _cursor;
        
        [SerializeField]
        private Tool _defaultTool;
        
        private Tool _currentTool;

        public Tool CurrentTool { get => _currentTool; set => _currentTool = value; }
        
        void Start()
        {
            SetTool(_defaultTool);
        }

        void Update()
        {
            if (Input.GetMouseButtonUp (0)) 
            {
                _currentTool.DoMouseUp();
            }
            
            if (Input.GetMouseButtonDown(0))
            {
                _currentTool.DoMouseDown();
            }
        }


        public void SetTool(Tool newTool)
        {
            _currentTool = newTool;
            _cursor.SetIcon(_currentTool.ToolIcon);
        }
    }
}