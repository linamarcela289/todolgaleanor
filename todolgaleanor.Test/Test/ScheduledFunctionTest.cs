using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using todolgaleanor.Functions.Function;
using todolgaleanor.Test.Helpers;
using Xunit;

namespace todolgaleanor.Test.Test
{
  public  class ScheduledFunctionTest
    {
        private readonly ILogger logger = TestFactory.CreateLogger();
        public void ScheduledFunctionTest_Should_Log_Messaga()
        {

            // Arrenge 
            MockCloudTableTodos mockTodos = new MockCloudTableTodos(new Uri("http://127.0.0.1:10002/devstoreaccount1/reports"));
            ListLogger logger = (ListLogger)TestFactory.CreateLogger(LoggerTypes.List);
            // Act
            ScheduledFunction.Run(null, mockTodos, logger);
            string message = logger.Logs[0];

            // Assert
            Assert.Contains("Deleting completed", message);
        }
    }
}
