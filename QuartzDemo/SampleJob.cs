using log4net;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzDemo
{
    public sealed class SampleJob:IJob
    {
        private static readonly ILog _logger = log4net.LogManager.GetLogger("SampleLog");

        public void Execute(IJobExecutionContext context)
        {
            _logger.Info("SampleJob测试");
            Console.WriteLine("执行任务" + DateTime.Now.ToLongDateString());
        }
    }
}
