using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.StrategyPattern
{
    public class HighContrastFilter : Filter
    {
        public void ApplyFilter(string filename)
        {
            Debug.Log($"Applying high constract filter to {filename}");
        }
    }
}
