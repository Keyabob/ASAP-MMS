namespace MMS.ELT.Data
{
    /// <summary>
    /// 股票财务数据
    /// </summary>
    public class StockFinInfo
    {
        /// <summary>
        /// 总股本
        /// </summary>
        public double TotalStock { get; set; }

        /// <summary>
        /// 每股收益
        /// </summary>
        public double EPS { get; set; }

        /// <summary>
        /// 流通A股
        /// </summary>
        public double AShares { get; set; }

        /// <summary>
        /// 每股净资产
        /// </summary>
        public double NAVPS { get; set; }

        /// <summary>
        /// 每股现金流
        /// </summary>
        public double CFPS { get; set; }

        /// <summary>
        /// 每股公积金
        /// </summary>
        public double AFPS { get; set; }

        /// <summary>
        /// 净资产收益率
        /// </summary>
        public double ROE { get; set; }

        /// <summary>
        /// 净利润增长率
        /// </summary>
        public double NPGR { get; set; }

        /// <summary>
        /// 每股未分配利润
        /// </summary>
        public double UDPPS { get; set; }

        /// <summary>
        /// 主营收入增长率
        /// </summary>
        public double MBRG { get; set; }

        /// <summary>
        /// 股票走势
        /// </summary>
        public string StockTrend { get; set; }

        /// <summary>
        /// 股票质地
        /// </summary>
        public string StockQuality { get; set; }
    }
}
