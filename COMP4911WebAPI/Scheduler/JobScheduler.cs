using COMP4911WebAPI.Jobs;
using Microsoft.Extensions.Configuration;
using Quartz;
using Quartz.Impl;

namespace COMP4911WebAPI.Scheduler
{
    public class JobScheduler
    {
        public async void Start(IConfiguration config)
        {
            string connstring = config.GetConnectionString("ConnString");
            ISchedulerFactory schedulerFactory = new StdSchedulerFactory();
            IScheduler scheduler = await schedulerFactory.GetScheduler();
            await scheduler.Start();

            IJobDetail reportJob = JobBuilder.Create<Jobs.ReportJob>()
                .WithIdentity("GenerateProjectReport", "Group1")
                .UsingJobData("connectionstring", connstring)
                .Build();

            ITrigger trigger = TriggerBuilder.Create()

                .WithIdentity("HelloJob ", "create")

                .WithSimpleSchedule(x => x
                //change how often job runs here (seconds for testing)
                //change to below in production
                //.WithIntervalInHours(24)
                .WithIntervalInSeconds(60) 
                .RepeatForever())

                .StartAt(System.DateTime.UtcNow)

                .WithPriority(1)

                .Build();

            await scheduler.ScheduleJob(reportJob, trigger);

        }
    }
}