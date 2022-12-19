using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.StatePattern
{
    public class SelectionTool : Tool
    {
        public override void DoMouseUp()
        {
            Debug.Log($"Selection Tool: Mouse Up");
        }

        public override void DoMouseDown()
        {
            Debug.Log($"Selection Tool: Mouse Down");
        }
    }
}