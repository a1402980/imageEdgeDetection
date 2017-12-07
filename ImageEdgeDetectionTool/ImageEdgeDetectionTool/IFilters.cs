using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEdgeDetectionTool
{
    public interface IFilters
    {
        Bitmap NightFilter();
        Bitmap ZenFilter();
    }
}
