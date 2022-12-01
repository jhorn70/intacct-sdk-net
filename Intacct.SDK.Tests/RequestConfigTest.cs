using System;
using System.Text;
using Xunit;

namespace Intacct.SDK.Tests
{
    public class RequestConfigTest
    {
        [Fact]
        public void ExecuteTest()
        {
            RequestConfig requestConfig = new RequestConfig()
            {
                ControlId = "unittest"
            };
            
            Assert.Equal("unittest", requestConfig.ControlId);
            Assert.Equal(Encoding.GetEncoding("UTF-8"), requestConfig.Encoding);
            Assert.Equal(5, requestConfig.MaxRetries);
            Assert.Equal(new[] { 524 }, requestConfig.NoRetryServerErrorCodes);
            Assert.Equal("", requestConfig.PolicyId);
            Assert.False(requestConfig.Transaction);
            Assert.False(requestConfig.UniqueId);
        }
    }
}