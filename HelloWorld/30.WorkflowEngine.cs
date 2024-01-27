using System;
namespace HelloWorld
{
	public interface IActivity
	{
		void Execute();
	}

	public interface IWorkflow
	{
		void AddActivity(IActivity activity);
		void RemoveActivity(IActivity activity);
		IEnumerable<IActivity> GetActivities();
	}


	/* Creating activities for our workflow */
	public class UploadVideoActivity : IActivity
	{
		public void Execute()
		{
			Console.WriteLine("Uploading Video");
		}
	}
	public class CallEncondingServiceActivity : IActivity
	{
		public void Execute()
		{
			Console.WriteLine("Calling web service for video encoding ready");
		}
	}
	public class SendEmailActivity : IActivity
	{
		public void Execute()
		{
			Console.WriteLine("Sending email to video owner");
		}
	}
	public class ProcessVideoActivity : IActivity
	{
		public void Execute()
		{
			Console.WriteLine("Video is now being processed");
		}
	}

	public class Workflow : IWorkflow
	{
		private readonly List<IActivity> _activities = new List<IActivity>();

		public void AddActivity(IActivity activity)
		{
			if (activity == null)
				throw new NullReferenceException("No activity provided to be added");

            _activities.Add(activity);
		}

		public void RemoveActivity(IActivity activity)
		{
			if (activity == null)
				throw new NullReferenceException("No activity provided for removal");

			_activities.Remove(activity);
        }

		public IEnumerable<IActivity> GetActivities()
		{
			return _activities;
		}
	}

    public class WorkflowEngine
    {
        private readonly IWorkflow _workflow;

        public WorkflowEngine(IWorkflow workflow)
        {
            if (workflow.GetActivities().Count() == 0)
				throw new NullReferenceException("Empty workflow provided");
            _workflow = workflow;
        }

        public void Run()
        {
			if (_workflow.GetActivities().Count() == 0)
				throw new NullReferenceException("Empty workflow provided");

            foreach (var activity in _workflow.GetActivities())
                activity.Execute();
        }
    }


    /* ============================= */
    /* Entrypoint to the application */
    /* ============================= */
    public class WorkflowEntrypoint
	{
		public static void Entrypoint()
		{
			Workflow videoUploadWorkflow = new Workflow();

			videoUploadWorkflow.AddActivity(new UploadVideoActivity());
			videoUploadWorkflow.AddActivity(new CallEncondingServiceActivity());
			videoUploadWorkflow.AddActivity(new SendEmailActivity());
			videoUploadWorkflow.AddActivity(new ProcessVideoActivity());

			WorkflowEngine workflowEngine = new WorkflowEngine(videoUploadWorkflow);
			workflowEngine.Run();
		}
	}
}

