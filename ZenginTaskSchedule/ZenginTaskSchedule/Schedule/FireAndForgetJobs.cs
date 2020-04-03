using System;
using Hangfire;

namespace ZenginTaskSchedule.Schedule
{
    public static class FireAndForgetJobs
    {
       
        public static  void MyAction()
        {
            //to do jobs
            BackgroundJob.Enqueue(()=>ProcessFireAndForgetJob());    
            
        }
        public static  void ProcessFireAndForgetJob()
        {
            //what do you want?
        }
    }
}