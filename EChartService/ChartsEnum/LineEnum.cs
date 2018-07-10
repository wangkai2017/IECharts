using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EChartService.ChartsEnum
{
    /// <summary>
    /// 折线类型枚举
    /// </summary>
    public enum LineEnum
    {
        /// <summary>
        /// 基础折线图
        /// </summary>
        BasicLine,
        /// <summary>
        /// 基础折线面积图
        /// </summary>
        BasicArea,
        /// <summary>
        /// 平滑折线图
        /// </summary>
        SmoothedLine,
        /// <summary>
        /// 叠层线
        /// </summary>
        StackedLine,
        /// <summary>
        /// 叠层面积图
        /// </summary>
        StackedAreaChart,
        /// <summary>
        /// 降雨量
        /// </summary>
        Rainfall,
        /// <summary>
        /// 大面积图
        /// </summary>
        LargeScaleArea,
        /// <summary>
        /// 波段图
        /// </summary>
        ConfidenceBand,
        /// <summary>
        /// 动态数据与时间轴
        /// </summary>
        DynammicDataAndTimeAxis,
        /// <summary>
        /// 雨量关系图
        /// </summary>
        RainfallAndWaterFlow,
        /// <summary>
        /// 可拖动点位图
        /// </summary>
        TryDraggingThesePoints,
        /// <summary>
        /// 可添加点位图
        /// </summary>
        ClickToAddPoints,
        /// <summary>
        /// 脉冲图
        /// </summary>
        StepLine,
    }
}
