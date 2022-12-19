using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.StrategyPattern
{
    public class PngCompressor : Compressor
    {
        public void Compress(string filename)
        {
            Debug.Log($"Compressing {filename} with PNG Compression.");
        }
    }
}
