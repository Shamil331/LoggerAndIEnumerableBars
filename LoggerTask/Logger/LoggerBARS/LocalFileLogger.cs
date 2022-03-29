namespace LoggerBARS
{
    public class LocalFileLogger<T> : ILogger
    {
        public string path = "logerFile.txt";
        private void WriteFile(string message)
        {
            File.AppendAllText(path, message);
        }
        public void LogError(string message, Exception ex)
        {
            string msg = $"[Error] : [{typeof(T)}] : {message}. {ex.Message}\n";
            WriteFile(msg);
            Console.WriteLine(msg);

        }

        public void LogInfo(string message)
        {
            string msg = $"[Info]: [{typeof(T)}] : {message}\n";
            WriteFile(msg);
            Console.WriteLine(msg);
        }

        public void LogWarning(string message)
        {
            string msg = $"[Warning] : [{typeof(T)}] : {message}\n";
            WriteFile(msg);
            Console.WriteLine(msg);
        }
    }
}
