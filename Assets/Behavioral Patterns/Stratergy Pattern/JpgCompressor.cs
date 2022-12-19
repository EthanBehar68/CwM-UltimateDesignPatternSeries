using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.StrategyPattern
{
    public class JpgCompressor : Compressor
    {
        public void Compress(string filename)
        {
            Debug.Log($"Compressing {filename} with JPG Compression.");
        }
    }
}
