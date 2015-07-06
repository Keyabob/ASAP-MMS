using System.Collections;
using System.Collections.Generic;
using MMS.ELT.Data;

namespace MMS.ELT
{
    /// <summary>
    /// 远程数据抽取
    /// </summary>
    public interface IRemoteDataExtractor
    {
        /// <summary>
        /// 获取指定股票代码的财务信息数据
        /// </summary>
        /// <param name="code">指定的股票代码</param>
        /// <param name="type">指定的股票类型</param>
        /// <returns>如果成功，则返回对应的财务数据对象，否则返回空</returns>
        StockFinInfo GetFinInfo(string code, string type);

        /// <summary>
        /// 获取指定股票集合的实时数据列表
        /// </summary>
        /// <param name="codeAndTypes">股票代码类型集合</param>
        /// <returns>返回实时数据集合</returns>
        IList<RealTimeStockItem> GetRealTimeData(IList<string> codeAndTypes);


    }
}
