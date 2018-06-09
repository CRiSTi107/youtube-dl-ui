using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace youtube_dl_ui
{
    public class youtube_dl
    {
        [DllImport("kernel32", SetLastError = true)]
        static extern int AttachConsole(int pid);
        [DllImport("kernel32", SetLastError = true)]
        static extern int FreeConsole();
        [DllImport("kernel32")]
        static extern SafeFileHandle GetStdHandle(int stdHandle);

        public const string DEFAULT_COMMAND = @"youtube-dl --extract-audio --audio-format mp3 --audio-quality 0 <Video-URL> -o %(title)s.%(ext)s";
        public const string URL_TO_REPLACE  = @"<Video-URL>";

        private List<string> _URLs = new List<string>();
        private string _Command = DEFAULT_COMMAND;

        public youtube_dl()
        {
            if (_URLs.Count > 0)
                _URLs.Clear();
        }
        public youtube_dl(string URLs)
        {
            if(_URLs.Count > 0)
                _URLs.Clear();
            foreach(var URL in URLs.Split(new[] { Environment.NewLine }, StringSplitOptions.None))
                if(URL != null)
                    if(URL != "" | URL != String.Empty)
                        _URLs.Add(URL);
        }


        public void Add(string URL, bool CheckIfExists = false)
        {
            if(!CheckIfExists)
                if (URL != "" | URL != String.Empty)
                    _URLs.Add(URL);
            else if (!_URLs.Contains(URL))
                    if (URL != "" | URL != String.Empty)
                        _URLs.Add(URL);
        }
        public void Remove(string URL, bool RemoveAll = false)
        {
            if(RemoveAll)
            {
                if (_URLs.Contains(URL))
                    _URLs.RemoveAll(item => item == URL);
            }
            else if (_URLs.Contains(URL))
                _URLs.Remove(URL);
        }
        public void Clear()
        {
            if (_URLs.Count > 0)
                _URLs.Clear();
        }
        public void LoadFromFile(string Path)
        {
            if (_URLs.Count > 0)
                _URLs.Clear();
            foreach (string URL in GetListFromFile(Path))
                if (URL != "" | URL != String.Empty)
                    _URLs.Add(URL);
        }


        public List<string> GetURLs()
        {
            return _URLs;
        }


        public void ResetCommand()
        {
            _Command = DEFAULT_COMMAND;
        }
        public string Command
        {
            set
            {
                _Command = value;
            }
            get
            {
                return _Command;
            }
        }


        public void Download()
        {
            foreach (var URL in _URLs)
            {
                Download(URL);
            }
        }
        public void Download(ref string _output, ref string _error)
        {
            foreach(var URL in _URLs)
            {
                Download(URL, ref _output, ref _error);
            }
        }
        private void Download(string URL)
        {
            Process process = new Process();
            process.StartInfo.FileName = _Command.Split(' ')[0];
            process.StartInfo.Arguments = _Command.Split(new[] { ' ' }, 2)[1].Replace(@"<Video-URL>", URL);
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.WaitForExit();
        }
        private void Download(string URL, ref string _output, ref string _error)
        {
            Process process = new Process();
            process.StartInfo.FileName = _Command.Split(' ')[0];
            process.StartInfo.Arguments = _Command.Split(new[] { ' ' }, 2)[1].Replace(@"<Video-URL>", URL);
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start();

            _output = process.StandardOutput.ReadToEnd();
            _error = process.StandardError.ReadToEnd();
            process.WaitForExit();
        }


        private List<string> GetListFromFile(string Path)
        {
            List<string> List = new List<string>();

            StreamReader File = new StreamReader(Path);
            while(!File.EndOfStream)
            {
                string tmp = File.ReadLine();
                if (tmp != "" | tmp != String.Empty)
                    List.Add(tmp);
            }
            File.Close();

            return List;
        }
    }
}
