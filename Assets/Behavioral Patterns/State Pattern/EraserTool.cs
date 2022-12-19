using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.StatePattern
{
    public class EraserTool : Tool
    {
        public override void DoMouseUp()
        {
            Debug.Log($"Eraser Tool: Mouse Up");
        }

        public override void DoMouseDown()
        {
            Debug.Log($"Eraser Tool: Mouse Down");
        }
    }
}