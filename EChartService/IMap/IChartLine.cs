using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EChartService.IMap
{
    public interface IChartLine
    {
        /// <summary>
        /// 设置X轴数据
        /// </summary>
        void SetXData();
        /// <summary>
        /// 设置Y轴数据
        /// </summary>
        void SetYData();
    }
}
