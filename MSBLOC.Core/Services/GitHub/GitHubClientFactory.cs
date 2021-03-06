using MSBLOC.Core.Interfaces.GitHub;
using Octokit;

namespace MSBLOC.Core.Services.GitHub
{
    /// <inheritdoc />
    public class GitHubClientFactory : IGitHubClientFactory
    {
        public const string UserAgent = "MSBuildLogOctokitChecker";

        /// <inheritdoc />
        public IGitHubClient CreateClient(string token)
        {
            return GitHubClientFactoryHelper.GitHubClient(token, UserAgent);
        }

        /// <inheritdoc />
        public IGitHubGraphQLClient CreateGraphQLClient(string token)
        {
            return GitHubClientFactoryHelper.GraphQLClient(token, UserAgent);
        }
    }
}