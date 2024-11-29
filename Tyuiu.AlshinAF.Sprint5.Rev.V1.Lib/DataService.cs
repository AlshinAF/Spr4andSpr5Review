namespace Tyuiu.AlshinAF.Sprint5.Rev.V1.Lib
{
    public class DataService
    {
        public string LoadDataAndSave(string path)
        {
            string[] paths = { @"C:\DataSprint5", "OutPutDataFileTask7V1.txt" };
            string pathSaveFile = Path.Combine(paths);
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }
            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string words = line.Replace("123 ", "").Replace(" 456", "");
                    strLine += words;
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;


        }
    }
}
