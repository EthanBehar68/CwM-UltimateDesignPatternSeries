using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.StrategyPattern
{
    public class StrategyExampleController : MonoBehaviour
    {
        private ImageStore _imageStore;

        void Start()
        {
            Debug.Log("Image Compressor set up with Jpg Compression and Black and White Filter to start.");
            _imageStore = new ImageStore(new JpgCompressor(), new BlackAndWhiteFilter());    
        }

        public void SwitchToBlackAndWhiteFilter()
        {
            Debug.Log("Applying Black and White Filter.");
            _imageStore.Filter = new BlackAndWhiteFilter();
        }

        public void SwitchToHighContrastFilter()
        {
            Debug.Log("Applying High Contrast Filter.");
            _imageStore.Filter = new HighContrastFilter();
        }

        public void SwitchToJpgCompressor()
        {
            Debug.Log("Swithcing to Jpg Compression.");
            _imageStore.Compressor = new JpgCompressor();
        }

        public void SwitchToPngCompressor()
        {
            Debug.Log("Swithcing to Png Compression.");
            _imageStore.Compressor = new PngCompressor();
        }

        public void StoreImage()
        {
            Debug.Log("(Mock) Storing image...");
            _imageStore.StoreImage("ExampleImage.png");
        }
    }
}
