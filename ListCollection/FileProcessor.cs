using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace CollectionComparison
{
    public class FileProcessor
    {
        private string url;
        private string fileName;
        public string path;

        public FileProcessor()
        {
            this.url = "https://lms.skillfactory.ru/assets/courseware/v1/dc9cf029ae4d0ae3ab9e490ef767588f/asset-v1:SkillFactory+CDEV+2021+type@asset+block/Text1.txt";
            this.fileName = "cdev23_Words.txt";
        }

        public void Download()
        {
            WebClient client = new WebClient();
            client.DownloadFile(url, "cdev23_Words.txt");
        }
        public void Move()
        {
            string pathFrom = @"C:\\Store\\C#\\SF\\Collections\\CollectionsHW\\CollectionsHW\\ListCollection\\bin\\Debug\\cdev23_Words.txt";
            path = @"C:\\Store\\C#\\SF\\cdev23_Words.txt";
            if (File.Exists(path)) File.Delete(path);
            File.Move(pathFrom, path);
        }
    }
}
