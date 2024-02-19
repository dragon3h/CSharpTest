namespace CSharpTest.Services;

public class FileDownloadService
{
    private const string StorageFolder = "c:\\Download";
    public async Task DownloadFileAsync(string url)
    {
        // TODO 09: Download the file asyncronously from the given url to the StorageFolder
        // Use HttpClient for downloading and ensure the method handles exceptions properly.
        // url example:
        // https://download.visualstudio.microsoft.com/download/pr/f2b824c4-d65c-406a-9d3c-3fc4c45f402b/54a17e458c67caf84e4117783e1d2c40/aspnetcore-runtime-8.0.2-win-x64.zip
    }
}