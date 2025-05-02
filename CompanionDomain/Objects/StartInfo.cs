using System.Diagnostics;

namespace CompanionDomain.Objects
{
    public class StartInfo
    {
        public ProcessStartInfo Info { get; }

        public StartInfo(string fileName, string args, string? workingDirectory, bool redirectOutput = true, bool redirectError = true, bool createNoWindow = true, bool useShellExecute = false)
        {
            Info = new ProcessStartInfo()
            {
                FileName = fileName,
                Arguments = args,
                WorkingDirectory = workingDirectory,
                RedirectStandardOutput = redirectOutput,
                RedirectStandardError = redirectError,
                CreateNoWindow = createNoWindow,
                UseShellExecute = useShellExecute
            };
        }
    }
}
