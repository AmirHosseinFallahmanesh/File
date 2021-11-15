using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Service
{
    public class ViewerCountService: IViewerCountService
    {
        private int counter;
        public ViewerCountService()
            {
            counter = 0;


        }

        public int Count()
        {
            return ++counter;
        }
    }

    public interface IViewerCountService
    {
        int Count();
    }
}
