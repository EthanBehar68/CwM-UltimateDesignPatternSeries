using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.StrategyPattern
{
    public class ImageStore
    {
        public Compressor Compressor { get; set; }
        public Filter Filter { get; set; }

        public ImageStore(Compressor compressor, Filter filter)
        {
            Compressor = compressor;
            Filter = filter;
        }

        public void StoreImage(string filename)
        {
            // Details of compression pushed down into compressor objects
            // Practices single responsibility and Open-Close Principle (open for extension, closed for modification)
            Compressor.Compress(filename);

            // Details of filtering pushed down into filter objects
            // Practices single responsibility and Open-Close Principle (open for extension, closed for modification)
            Filter.ApplyFilter(filename);

            // Save file.
        }
    }
}
