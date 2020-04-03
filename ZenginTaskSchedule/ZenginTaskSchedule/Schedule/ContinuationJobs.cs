using System;
using Hangfire;

namespace ZenginTaskSchedule.Schedule
{
    public static class ContinuationJobs
    {
       
        public static  void MyAction()
        {
           
            var parentJobId = BackgroundJob.Schedule(() => Console.WriteLine("!Delayed Job !!"), TimeSpan.FromMinutes(4));
 
            //Continuations job
            BackgroundJob.ContinueWith(parentJobId, () => ProcessContinuationJobs());
            
        }
        public static  void ProcessContinuationJobs()
        {
            //what do you want?
        }
    }
}