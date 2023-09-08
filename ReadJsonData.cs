namespace Automation_exercise_com
{
    public class ReadJsonData
    {
        private IConfigurationRoot _config;

        public ReadJsonData()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("settings.json");
            _config = builder.Build();
        }

        public string GetData(string key) => _config[key]!;
    }
}
