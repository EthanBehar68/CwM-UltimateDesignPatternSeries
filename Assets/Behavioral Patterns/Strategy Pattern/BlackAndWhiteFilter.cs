using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.StrategyPattern
{
    public class BlackAndWhiteFilter : Filter
    {
        public void ApplyFilter(string filename)
        {
            Debug.Log($"Applying black and white filter to {filename}");
        }
    }
}
