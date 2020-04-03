using System;
using Hangfire;

namespace ZenginTaskSchedule.Schedule
{
    public static class RecurringJobs
    {
       
        public static  void MyAction()
        {
            //to do jobs
            RecurringJob.AddOrUpdate(() => ProcessRecurringJobs(), Cron.Hourly);    
            
        }
        public static  void ProcessRecurringJobs()
        {
            //what do you want?
        }
    }
}