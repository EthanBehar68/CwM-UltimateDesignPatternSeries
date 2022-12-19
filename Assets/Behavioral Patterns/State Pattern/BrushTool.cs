using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Vectorform.DesignPatternCookbook.StatePattern
{
    public class BrushTool : Tool
    {
        public override void DoMouseUp()
        {
            Debug.Log($"Brush Tool: Mouse Up");
        }

        public override void DoMouseDown()
        {
            Debug.Log($"Brush Tool: Mouse Down");
        }
    }
}