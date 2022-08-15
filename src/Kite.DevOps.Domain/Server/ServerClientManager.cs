using Renci.SshNet;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;


namespace Kite.DevOps.Domain.Server
{
    internal class ServerClientManager : ITransientDependency,IServerClientManager
    {
        private SshClient _sshClient;
        private ShellStream _shellStream;
        private StreamReader _reader;
        private StreamWriter _writer;

        public Task CloseShellCommandStreamAsync()
        {
            if (_writer != null)
                _writer.Close();
            if (_reader != null)
                _reader.Close();
            if (_shellStream != null)
                _shellStream.Close();
            return Task.CompletedTask;
        }

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

        public Task CreateShellCommandStreamAsync()
        {
            if (_shellStream != null)
                _shellStream = null;
            if (_reader != null)
                _reader = null;
            if (_writer != null)
                _writer = null;
            _shellStream = _sshClient.CreateShellStream(string.Empty, 0, 0, 0, 0, 0);
            _reader = new StreamReader(_shellStream);
            _writer = new StreamWriter(_shellStream);
            _writer.AutoFlush = true;
            return Task.CompletedTask;
        }

        public Task ReadByEndOfAsync(Action<string> action)
        {
            try
            {
                string line;
                for (int i = 0; i < 3; i++)
                {
                    do
                    {
                        line = _reader.ReadLine();
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            action(line);
                        }
                    } while (!_reader.EndOfStream);
                    Thread.Sleep(500);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
            }
            return Task.CompletedTask;
        }

        public Task WriteShellCommandStreamAsync(string command)
        {
            if (_writer != null)
            {
                _writer.WriteLine(command);
                while (_shellStream.Length == 0)
                {
                    Thread.Sleep(500);
                }
            }
            return Task.CompletedTask;
        }
    }
}
