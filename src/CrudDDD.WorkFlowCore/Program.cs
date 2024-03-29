﻿using CrudDDD.WorkFlowCore.DTOs;
using CrudDDD.WorkFlowCore.Flows;
using CrudDDD.WorkFlowCore.Steps;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using WorkflowCore.Interface;

namespace CrudDDD.WorkFlowCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IServiceProvider serviceProvider = ConfigureServices();

            //start the workflow host
            var host = serviceProvider.GetService<IWorkflowHost>();
            //host.RegisterWorkflow<HelloWorldWorkFlow>();
            host.RegisterWorkflow<PassingDataWorkflow, MyData>();
            host.RegisterWorkflow<PassingDataWorkflow2, Dictionary<string, int>>();
            host.Start();

            var initialData = new MyData
            {
                Value1 = 2,
                Value2 = 3
            };

            host.StartWorkflow("PassingDataWorkflow", 1, initialData);


            var initialData2 = new Dictionary<string, int>
            {
                ["Value1"] = 7,
                ["Value2"] = 2
            };

            host.StartWorkflow("PassingDataWorkflow2", 1, initialData2);
            //host.StartWorkflow("HelloWorld");

            Console.ReadLine();
            host.Stop();
        }

        private static IServiceProvider ConfigureServices()
        {
            //setup dependency injection
            IServiceCollection services = new ServiceCollection();
            services.AddLogging();
            services.AddWorkflow();
            //services.AddWorkflow(x => x.UseMongoDB(@"mongodb://localhost:27017", "workflow"));
            services.AddTransient<GoodByeWorld>();

            var serviceProvider = services.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
