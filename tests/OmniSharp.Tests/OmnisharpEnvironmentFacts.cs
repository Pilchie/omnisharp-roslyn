using Microsoft.Framework.Logging;
using OmniSharp.Services;
using Xunit;

namespace OmniSharp.Tests       
{
    public class OmnisharpEnvironmentFacts
    {
        [Fact]
        public void OmnisharpEnvironmentSetsPathsCorrectly()
        {
            var environment = new OmnisharpEnvironment(@"foo.sln", 1000, TraceType.Information);

            Assert.Equal(@"foo.sln", environment.SolutionFilePath);
            Assert.Equal(@"", environment.Path);
            Assert.Equal(1000, environment.Port);
        }

        [Fact]
        public void OmnisharpEnvironmentHasNullSolutionFilePathIfDirectorySet()
        {
            var environment = new OmnisharpEnvironment(@".", 1000, TraceType.Information);

            Assert.Null(environment.SolutionFilePath);
            Assert.Equal(@".", environment.Path);
            Assert.Equal(1000, environment.Port);
        }
    }
}
