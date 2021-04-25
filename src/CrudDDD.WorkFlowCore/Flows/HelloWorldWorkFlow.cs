using CrudDDD.WorkFlowCore.Steps;
using WorkflowCore.Interface;

namespace CrudDDD.WorkFlowCore.Flows
{
    public class HelloWorldWorkFlow : IWorkflow
    {
        public void Build(IWorkflowBuilder<object> builder)
        {
            builder
                .StartWith<HelloWorld>()
                .Then<GoodByeWorld>();
        }

        public string Id => "HelloWorld";

        public int Version => 1;

    }
}
