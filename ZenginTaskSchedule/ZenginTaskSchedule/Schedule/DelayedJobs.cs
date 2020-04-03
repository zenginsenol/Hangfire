using System;
using Hangfire;

namespace ZenginTaskSchedule.Schedule
{
    public static class DelayedJobs
    {
       
        public static  void MyAction()
        {
            //to do jobs
            BackgroundJob.Schedule(() => ProcessDelayedJob(),TimeSpan.FromHours(1));    
            
        }
        public static  void ProcessDelayedJob()
        {
            //what do you want?
        }
    }
}