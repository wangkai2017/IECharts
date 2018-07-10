using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EChartService.Common
{
    /// <summary>
    /// 标题组件，包含主标题和副标题。
    /// </summary>
    public class Title
    {
        public Title()
        {
            this.Show = true;
            this.Text = string.Empty;
            this.Line = string.Empty;
            this.Target = "blank";
            this.TextStyle = new TextStyle();
            this.SubText = string.Empty;
            this.SubLink = string.Empty;
            this.SubTarget = "blank";
            this.SubTextStyle = new TextStyle();
            this.Padding = 5;
            this.ItemGap = 10;
            this.Zlevel = 0;
            this.Z = 2;
            this.Left = "auto";
            this.Top = "auto";
            this.Right = "auto";
            this.Bottom = "auto";
            this.BackgroundColor = "transparent";
            this.BorderColor = "#ccc";
            this.BorderWidth = 0;
            this.BorderRaius = 0;
            this.ShadowBlur = 0;
            this.ShadowColor = string.Empty;
            this.ShadowOffsetX = 0;
            this.ShadowOffsetY = 0;
        }
        /// <summary>
        /// 组件 ID。默认不指定。指定则可用于在 option 或者 API 中引用组件。
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 是否显示标题组件。
        /// </summary>
        public bool Show { get; set; }
        /// <summary>
        /// 主标题文本，支持使用 \n 换行。
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// 主标题文本超链接。
        /// </summary>
        public string Line { get; set; }
        /// <summary>
        /// 指定窗口打开主标题超链接。 'self' 当前窗口打开 'blank' 新窗口打开
        /// </summary>
        public string Target { get; set; }
        /// <summary>
        /// 文本样式
        /// </summary>
        public TextStyle TextStyle { get; set; }
        /// <summary>
        /// 副标题文本，支持使用 \n 换行。
        /// </summary>
        public string SubText { get; set; }
        /// <summary>
        /// 副标题文本超链接。
        /// </summary>
        public string SubLink { get; set; }
        /// <summary>
        /// 指定窗口打开副标题超链接，可选：'self' 当前窗口打开 'blank' 新窗口打开
        /// </summary>
        public string SubTarget { get; set; }
        /// <summary>
        /// 副标题文本样式
        /// </summary>
        public TextStyle SubTextStyle { get; set; }
        /// <summary>
        /// 标题内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距。
        /// </summary>
        public dynamic Padding { get; set; }
        /// <summary>
        /// 主副标题之间的间距。
        /// </summary>
        public int ItemGap { get; set; }
        /// <summary>
        /// 所有图形的 zlevel 值。
        /// </summary>
        public int Zlevel { get; set; }
        /// <summary>
        /// 组件的所有图形的z值。控制图形的前后顺序。z值小的图形会被z值大的图形覆盖。
        /// </summary>
        public int Z { get; set; }
        /// <summary>
        /// grid 组件离容器左侧的距离。
        /// </summary>
        public string Left { get; set; }
        /// <summary>
        /// grid 组件离容器上侧的距离。
        /// </summary>
        public string Top { get; set; }
        /// <summary>
        /// grid 组件离容器右侧的距离。
        /// </summary>
        public string Right { get; set; }
        /// <summary>
        /// grid 组件离容器下侧的距离。
        /// </summary>
        public string Bottom { get; set; }
        /// <summary>
        /// 标题背景色，默认透明。
        /// </summary>
        public string BackgroundColor { get; set; }
        /// <summary>
        /// 标题的边框颜色。
        /// </summary>
        public string BorderColor { get; set; }
        /// <summary>
        /// 标题的边框线宽。
        /// </summary>
        public int BorderWidth { get; set; }
        /// <summary>
        /// 圆角半径，单位px，支持传入数组分别指定 4 个圆角半径。
        /// </summary>
        public dynamic BorderRaius { get; set; }
        /// <summary>
        /// 图形阴影的模糊大小。
        /// </summary>
        public int ShadowBlur { get; set; }
        /// <summary>
        /// 阴影颜色。
        /// </summary>
        public string ShadowColor { get; set; }
        /// <summary>
        /// 阴影水平方向上的偏移距离。
        /// </summary>
        public int ShadowOffsetX { get; set; }
        /// <summary>
        /// 阴影垂直方向上的偏移距离。。
        /// </summary>
        public int ShadowOffsetY { get; set; }

    }
    public class TextStyle
    {
        public TextStyle()
        {
            this.Color = string.Empty;
            this.FontStyle = "normal";
            this.FontWeight = "normal";
            this.FontFamily = "sans-serif";
            this.FontSize = 18;
            this.TextBorderColor = "transparent";
            this.TextBorderWidth = 0;
            this.TextShadowColor = "transparent";
            this.TextShadowBlur = 0;
            this.TextShadowOffsetX = 0;
            this.TextShadowOffsetY = 0;
        }

        /// <summary>
        /// 主标题文字的颜色。
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// 主标题文字字体的风格 可选 normal italic oblique
        /// </summary>
        public string FontStyle { get; set; }
        /// <summary>
        /// 主标题文字字体的粗细 可选 normal bold bolder lighter 100|200|300...
        /// </summary>
        public string FontWeight { get; set; }
        /// <summary>
        /// 主标题文字的字体系列 还可以是 'serif' , 'monospace', 'Arial', 'Courier New', 'Microsoft YaHei', ...
        /// </summary>
        public string FontFamily { get; set; }
        /// <summary>
        /// 主标题文字的字体大小 
        /// </summary>
        public int FontSize { get; set; }
        /// <summary>
        /// 文字水平对齐方式，默认自动。可选：'left' 'center' 'right'
        /// </summary>
        public string Align { get; set; }
        /// <summary>
        /// 文字垂直对齐方式，默认自动。可选：'top' 'middle' 'bottom'
        /// </summary>
        public string VerticalAlign { get; set; }
        /// <summary>
        /// 行高。
        /// </summary>
        public int LineHeight { get; set; }
        /// <summary>
        /// 文字块的宽度
        /// </summary>
        public string Width { get; set; }
        /// <summary>
        /// 文字块的高度
        /// </summary>
        public string Height { get; set; }
        /// <summary>
        /// 文字本身的描边颜色。
        /// </summary>
        public string TextBorderColor { get; set; }
        /// <summary>
        /// 文字本身的描边宽度。
        /// </summary>
        public int TextBorderWidth { get; set; }
        /// <summary>
        /// 文字本身的阴影颜色。
        /// </summary>
        public string TextShadowColor { get; set; }
        /// <summary>
        /// 文字本身的阴影长度。
        /// </summary>
        public int TextShadowBlur { get; set; }
        /// <summary>
        /// 文字本身的阴影 X 偏移。
        /// </summary>
        public int TextShadowOffsetX { get; set; }
        /// <summary>
        /// 文字本身的阴影 Y 偏移。
        /// </summary>
        public int TextShadowOffsetY { get; set; }
        /// <summary>
        /// 在 rich 里面，可以自定义富文本样式。利用富文本样式，可以在标签中做出非常丰富的效果。
        /// </summary>
        public object Rick { get; set; }
    }

    /// <summary>
    /// 图例组件。
    /// </summary>
    public class Legend
    {
        public Legend()
        {
            this.Show = true;
            this.Zlevel = 0;
            this.Z = 2;
            this.Left = "auto";
            this.Top = "auto";
            this.Right = "auto";
            this.Bottom = "auto";
            this.Width = "auto";
            this.Height = "auto";
            this.Orient = "horizontal";
            this.Align = "auto";
            this.Padding = 5;
        }
        /// <summary>
        /// 图例的类型。可选值：'plain'：普通图例。缺省就是普通图例。 'scroll'：可滚动翻页的图例。当图例数量较多时可以使用。
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 组件 ID。
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 是否显示
        /// </summary>
        public bool Show { get; set; }
        /// <summary>
        /// 所有图形的 zlevel 值。
        /// </summary>
        public int Zlevel { get; set; }
        /// <summary>
        /// 组件的所有图形的z值。控制图形的前后顺序。z值小的图形会被z值大的图形覆盖。
        /// </summary>
        public int Z { get; set; }
        /// <summary>
        /// grid 组件离容器左侧的距离。
        /// </summary>
        public string Left { get; set; }
        /// <summary>
        /// grid 组件离容器上侧的距离。
        /// </summary>
        public string Top { get; set; }
        /// <summary>
        /// grid 组件离容器右侧的距离。
        /// </summary>
        public string Right { get; set; }
        /// <summary>
        /// grid 组件离容器下侧的距离。
        /// </summary>
        public string Bottom { get; set; }
        /// <summary>
        /// 图例组件的宽度。默认自适应。
        /// </summary>
        public string Width { get; set; }
        /// <summary>
        /// 图例组件的高度。默认自适应。
        /// </summary>
        public string Height { get; set; }
        /// <summary>
        /// 图例列表的布局朝向。        可选：'horizontal''vertical'
        /// </summary>
        public string Orient { get; set; }
        /// <summary>
        /// [ default: 'auto' ]
        ///图例标记和文本的对齐。默认自动，根据组件的位置和 orient 决定，当组件的 left 值为 'right' 以及纵向布局（orient 为 'vertical'）的时候为右对齐，及为 'right'。可选：'auto''left''right'        /// </summary>
        /// </summary>
        public string Align { get; set; }
        /// <summary>
        /// 图例内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距
        /// </summary>
        public int Padding { get; set; }
        /// <summary>
        /// 图例每项之间的间隔。横向布局时为水平间隔，纵向布局时为纵向间隔。
        /// </summary>
        public int ItemGap { get; set; }
        /// <summary>
        /// 图例标记的图形宽度。
        /// </summary>
        public int ItemWidth { get; set; }
        /// <summary>
        /// 图例标记的图形高度。
        /// </summary>
        public int ItemHeight { get; set; }
        /// <summary>
        /// 如果图标（可能来自系列的 symbol 或用户自定义的 legend.data.icon）是 path:// 的形式，是否在缩放时保持该图形的长宽比。
        /// </summary>
        public bool SymbolKeepAspect { get; set; }
        /// <summary>
        /// 用来格式化图例文本，支持字符串模板和回调函数两种形式。
        /// </summary>
        public string Formatter { get; set; }
        /// <summary>
        /// 图例选择的模式，控制是否可以通过点击图例改变系列的显示状态。默认开启图例选择，可以设成 false 关闭。
        /// </summary>
        public dynamic SelectedMode { get; set; }
        /// <summary>
        /// 图例关闭时的颜色。
        /// </summary>
        public string InactiveColor { get; set; }
        /// <summary>
        /// 图例选中状态表。
        /// </summary>
        public object Selected { get; set; }
        /// <summary>
        /// 图例的公用文本样式。
        /// </summary>
        public TextStyle TextStyle { get; set; }
        /// <summary>
        /// 图例的 tooltip 配置，配置项同 tooltip。
        /// </summary>
        public object ToolTip { get; set; }
        /// <summary>
        /// 图例的数据数组。数组项通常为一个字符串，每一项代表一个系列的 name（如果是饼图，也可以是饼图单个数据的 name）。图例组件会自动根据对应系列的图形标记（symbol）来绘制自己的颜色和标记，特殊字符串 ''（空字符串）或者 '\n'（换行字符串）用于图例的换行。
        /// </summary>
        public LegendData Data { get; set; }
        /// <summary>
        /// 图例背景色，默认透明。
        /// </summary>
        public string BackgroundColor { get; set; }
        /// <summary>
        /// 图例的边框颜色。
        /// </summary>
        public string BorderColor { get; set; }
        /// <summary>
        /// 图例的边框线宽
        /// </summary>
        public int BorderWidth { get; set; }
        /// <summary>
        /// 圆角半径，单位px，支持传入数组分别指定 4 个圆角半径。 
        /// </summary>
        public dynamic BorderRadius { get; set; }
        /// <summary>
        /// 图形阴影的模糊大小。
        /// </summary>
        public int ShadowBlur { get; set; }
        /// <summary>
        /// 阴影颜色。
        /// </summary>
        public string ShadowColor { get; set; }
        /// <summary>
        /// 阴影水平方向上的偏移距离。
        /// </summary>
        public int ShadowOffsetX { get; set; }
        /// <summary>
        /// 阴影垂直方向上的偏移距离。
        /// </summary>
        public int ShadowOffsetY { get; set; }
        /// <summary>
        /// legend.type 为 'scroll' 时有效。        图例当前最左上显示项的 dataIndex。
        /// </summary>
        public int ScrollDataIndex { get; set; }
        /// <summary>
        /// legend.type 为 'scroll' 时有效。        图例控制块中，按钮和页信息之间的间隔。
        /// </summary>
        public int PageButtonItemGap { get; set; }
        /// <summary>
        /// legend.type 为 'scroll' 时有效。        图例控制块和图例项之间的间隔。
        /// </summary>
        public int PageButtonGap { get; set; }
        /// <summary>
        /// legend.type 为 'scroll' 时有效。        图例控制块的位置。可选值为：'start'：控制块在左或上。'end'：按钮快在右或下。
        /// </summary>
        public string PageButtonPosition { get; set; }
        /// <summary>
        /// legend.type 为 'scroll' 时有效。        图例控制块中，页信息的显示格式。默认为 '{current}/{total}'，其中 {currentz   }    是当前页号（从 1 开始计数），{total}是总页数。
        /// </summary>
        public string PageFormatter { get; set; }
        /// <summary>
        /// 图例控制块的图标。legend.type 为 'scroll' 时有效。
        /// </summary>
        public object PageIcons { get; set; }
        /// <summary>
        /// legend.type 为 'scroll' 时有效。        翻页按钮的颜色。
        /// </summary>
        public string PageIconColor { get; set; }
        /// <summary>
        /// legend.type 为 'scroll' 时有效。        翻页按钮不激活时（即翻页到头时）的颜色。
        /// </summary>
        public string PageIconInactiveColor { get; set; }
        /// <summary>
        /// legend.type 为 'scroll' 时有效。        翻页按钮的大小。可以是数字，也可以是数组，如[10, 3]，表示[宽，高]。
        /// </summary>
        public dynamic PageIconSize { get; set; }
        /// <summary>
        /// legend.type 为 'scroll' 时有效。        图例页信息的文字样式。
        /// </summary>
        public TextStyle PageTextStyle { get; set; }
        /// <summary>
        /// 图例翻页是否使用动画。
        /// </summary>
        public bool Animation { get; set; }
        /// <summary>
        /// 图例翻页时的动画时长。
        /// </summary>
        public int AnimationDurationUpdate { get; set; }
    }

    /// <summary>
    /// 图例的数据数组
    /// </summary>
    public class LegendData
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public TextStyle TextStyle { get; set; }
    }

    public class Grid
    {
        public string Id { get; set; }
        public bool Show { get; set; }
        public int ZLevel { get; set; }
        public int Z { get; set; }
        public string Left { get; set; }
        public string Top { get; set; }
        public string Right { get; set; }
        public string Bottom { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
    }
}
