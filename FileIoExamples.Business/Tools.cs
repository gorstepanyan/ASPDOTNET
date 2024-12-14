﻿namespace FileIOExamples.Business
{
    public class Tools : ITools
    {
        private readonly IToolsOption _option;

        public Tools(IToolsOption option)
        {
            _option = option;
        }

        public void Write(string text, string file)
        {
            if (_option.GetOptions() != "Stream")
            {
                throw new ArgumentException();
            }
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write(text);
            }
        }

        public string Read(string file)
        {
            if (_option.GetOptions() != "Stream")
            {
                throw new ArgumentException();
            }
            using (StreamReader reader = new StreamReader(file))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
