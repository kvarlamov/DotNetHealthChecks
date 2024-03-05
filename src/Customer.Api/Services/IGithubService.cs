namespace Customer.Api.Services;

internal interface IGithubService
{
    Task<bool> IsValidGithubUser(string userName);
}