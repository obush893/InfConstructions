﻿using System;
using System.Activities;
using System.Activities.DurableInstancing;
using System.Runtime.DurableInstancing;
using System.Threading;

namespace smFilestestApp
{
    class Class1
    {

        private SqlWorkflowInstanceStore store;
        private Workflow1 activity;
        private WorkflowApplication t;
        private AutoResetEvent instanceUnloaded = new AutoResetEvent(false);
        Guid id;
        public Class1()
        {

            activity = new Workflow1
            {
                DisplayName = "qqqqqqqqqqqqqqq",
                argument1 = "rrrrrrrrrrrrrrrrrrrrrrr"
            };

            //t = new WorkflowApplication(wq);
            // t.InstanceStore = store;

            InstanceHandle handle = store.CreateInstanceHandle();
            InstanceView view = store.Execute(handle, new CreateWorkflowOwnerCommand(), TimeSpan.FromSeconds(30));
            handle.Free();

            store.DefaultInstanceOwner = view.InstanceOwner;
            t.Load(Guid.Parse("4EE71B62-F1D0-46D1-8F53-4CAD8D76386A"));
        }
        private void SetupInstanceStore()
        {
            store = new SqlWorkflowInstanceStore("data source=MAKSIMOV;initial catalog=Activity1;persist security info=True;user id=Бушмакин;password=453459;multipleactiveresultsets=True;application name=eeeee");
            InstanceHandle handle = store.CreateInstanceHandle();
            InstanceView view = store.Execute(handle, new CreateWorkflowOwnerCommand(), TimeSpan.FromSeconds(30));
            handle.Free();
            store.DefaultInstanceOwner = view.InstanceOwner;
        }
        public void StartAndUnloadInstance()
        {
            WorkflowApplication application = new WorkflowApplication(activity)
            {
                InstanceStore = store,

                //returning IdleAction.Unload instructs the WorkflowApplication to persists application state and remove it from memory  
                PersistableIdle = (e) =>
                {
                    return PersistableIdleAction.Unload;
                },

                Unloaded = (e) =>
                {
                    instanceUnloaded.Set();
                }
            };


            //This call is not required 
            //Calling persist here captures the application durably before it has been started
            application.Persist();
            id = application.Id;
            application.Run();

            instanceUnloaded.WaitOne();
        }
    }
}
