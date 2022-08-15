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
        /// 持续读取响应结果到结束
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Task ReadByEndOfAsync(Action<string> action);
        /// <summary>
        /// 将命令行写入Shell脚本命令流
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        Task WriteShellCommandStreamAsync(string command);
        /// <summary>
        /// 关闭Shell脚本命令流
        /// </summary>
        /// <returns></returns>
        Task CloseShellCommandStreamAsync();
        /// <summary>
        /// 创建Shell脚本命令流
        /// </summary>
        /// <returns></returns>
        Task CreateShellCommandStreamAsync();
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
