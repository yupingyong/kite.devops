using Renci.SshNet;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;


namespace Kite.DevOps.Domain.Server
{
    internal class ServerClientManager : ITransientDependency,IServerClientManager
    {
        private SshClient _sshClient;
        public Task<bool> ConnectAsync(string host, int port, string userName, string password)
        {
            return Task.Factory.StartNew(() => 
            {
                try
                {
                    if (_sshClient == null)
                    {
                        _sshClient = new SshClient(host, port, userName, password);
                    }
                    if (!_sshClient.IsConnected)
                    {
                        _sshClient.Connect();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    Log.Error(ex, ex.Message);
                    return false;
                }
            });
        }

        public Task<List<string>> RunCommandAsync(string commandText)
        {

            return Task.Factory.StartNew(()=>
            {
                var result = new List<string>();
                try
                {
                    if (_sshClient == null || !_sshClient.IsConnected)
                    {
                        throw new ArgumentNullException("连接已断开");
                    }
                    var cmd = _sshClient.RunCommand(commandText);
                    var cmdResult = cmd.Result;
                    result.Add(cmdResult);
                    return result;
                }
                catch (Exception ex)
                {
                    Log.Error(ex, ex.Message);
                    result.Add(ex.Message);
                    return result;
                }
            });
        }
    }
}
