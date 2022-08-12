using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kite.DevOps.Domain.Server
{
    public interface IServerClientManager
    {
        /// <summary>
        /// 执行命令行
        /// </summary>
        /// <param name="commandText">命令行文本</param>
        /// <returns></returns>
        Task<List<string>> RunCommandAsync(string commandText);
        /// <summary>
        /// 服务器连接
        /// </summary>
        /// <param name="host">主机</param>
        /// <param name="port">端口号</param>
        /// <param name="userName">用户名</param>
        /// <param name="password">登录密码</param>
        /// <returns></returns>
        Task<bool> ConnectAsync(string host, int port, string userName, string password);
    }
}
