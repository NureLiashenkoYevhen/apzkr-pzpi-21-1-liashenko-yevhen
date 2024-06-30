namespace BLL.BackUp;

public interface IBackUpService
{
    Task SaveToCsv(string directoryPath);

    Task RestoreFromCsv(string directoryPath);

    Task<byte[]> DownloadAsZip(string directoryPath);
}
