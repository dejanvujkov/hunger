using LibGit2Sharp;

namespace Hunger.Data;

public class RepositoryInformation : IDisposable
{
    public const string GitUrl = "https://github.com/dejanvujkov/hunger";
    private bool _disposed;
    private readonly Repository _repo;

    public void Dispose()
    {
        if (_disposed) return;
        _disposed = true;
        _repo.Dispose();
    }

    public RepositoryInformation()
    {
        _repo = new Repository(Environment.CurrentDirectory);
    }

    public string GetLatestMasterCommitId() => _repo.Branches["origin/master"].Commits.First().Id.Sha;
}