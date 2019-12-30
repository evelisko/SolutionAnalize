using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SolutionAnalize
{
    public partial class Form1 : Form
    {
        public struct FileAttrib
        {
          public string fileName;
          public long fileSize;
          public string description;
        }

        public struct Solution
        {
            public string solutionName;
            public List<string> projects;
        }

        string[] projectsAll;  // список всех проектов в EAS-POS.
        string EAS_path;
        List<FileAttrib> FilesCompiling;
        List<FileAttrib> FilesWork;
        string filesPathCompilling;
        string filesPathWork;
        string filesPathProject;


        public Form1()
        {
            InitializeComponent();
            FilesCompiling = new List<FileAttrib>();
            FilesWork = new List<FileAttrib>();
            btnProjTree.Enabled = false; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDialogFileA = new FolderBrowserDialog();

            if (fbDialogFileA.ShowDialog() == DialogResult.OK)
            {
              
                tbSolutionFolder.Text = fbDialogFileA.SelectedPath;
                filesPathProject = fbDialogFileA.SelectedPath;
            }
        }

        //     Нужно название файла решения
        //   - список входящих в решение файлов. 
        //   

        // Выполняет сравнение файлов решений. 
        private void SolutionAnalize(string solutionFolder)
        {
            EAS_path = solutionFolder;
        
            projectsAll = Directory.GetFiles(EAS_path, "*.csproj", SearchOption.AllDirectories);

            List<Solution> solutions = SolutionList(EAS_path); // создаем список решений

            foreach (Solution solution in solutions)
            {
                tbLog.AppendText(solution.solutionName + "\r\n");
                foreach (string prg in solution.projects.ToArray())
                {
                    tbLog.AppendText("          " + prg + "\t" + ProgComarator(prg) + "\r\n"); // выводи результат работы функции. 
                }
            }

            tbLog.AppendText("\r\nСписок_проектов_не_пренадлежащих_ни_к_одному_решению \r\n\r\n");

            //  Нужно указывать имя проекта без пути

            int i;
            foreach (string prgName in projectsAll)
            {
                i = 0;
                foreach (Solution solution in solutions)
                {
                    foreach (string prg in solution.projects.ToArray())
                    {
                        string s2 = Path.GetFileName(prg);

                        string s3 = Path.GetFileName(prgName);

                        if (s2 == s3) i++;
                    }
                }
                if (i == 0)
                {
                  tbLog.AppendText(prgName + "\t" + ProgComarator(prgName) + "\r\n");
                }
            }


        }

        // Создает список решений. 
        //
        private List<Solution> SolutionList(string path)
        {
            string[] solutionArray = Directory.GetFiles(EAS_path, "*.sln", SearchOption.AllDirectories);

            List<Solution> solutions = new List<Solution>();
            Solution solution = new Solution();

            foreach (string solutionStr in solutionArray)
            {
                solution.solutionName = Path.GetFileName(solutionStr);
                solution.projects = progectsArray(solutionStr);
                solutions.Add(solution);
            }

            return solutions;
        }

        // выполняет разбор внутренней структуры файла sln. создает список проектов входящий в решение
        private List<string> progectsArray(string path)
        {
            List<string> projectsInSolution = new List<string>(); // string[1];  // список всех проектов в eas-pos.  
                                                                  //   Array.Resize()  
                                                                  //   SetLength(projectsInSolution = 

            // string[] allfilesa = directory.getfiles(filespatha, "*.cs", searchoption.alldirectories);

            StreamReader f = new StreamReader(path);
            while (!f.EndOfStream)
            {
                string s = f.ReadLine();
                // читаем новую строку. 
                // ищем в строке название файла и возвращаем результат. 
                string s1 = stringAnalizer(s);
                if (s1.Length > 0)
                    projectsInSolution.Add(s1);
            }
            f.Close();
            // производим построковый анализ файла. 
            // находим имя проекта в строке 

            return projectsInSolution;
        }

        private string stringAnalizer(string str)
        {
            string substr = "";

            string[] strings = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in strings)
            {
                if (s.Contains(".csproj"))
                {
                    substr = s.Trim(new char[] { ',', '\"' });
                    break;
                }
            }
            return substr;
        }



        private string ProgComarator(string projName)
        {
            string resultStr = "";
            // создаем список файлов имеющих расширение exe или dll. 
            // при заполнении таблицы указываем из размер 
            // Если файла не существует в скомпилированном и рабочем проекте, то ничего не пишем. "" // КР--- 
            // Если файл существует в рабочем решении, а в скомпилированном нет, то Р--- 
            // если размеры равны  ===  
            // Если размер не равны пишем разницу СК - Р
            // ,где СК - скомпилированный проект. 
            // Р - работающий проект полученный из установщика.  

            // нужно выполнить предварительную подготовку.  
            projName = Path.GetFileNameWithoutExtension(projName);


            foreach (FileAttrib fa in FilesWork.ToArray())
            {
                if (Path.GetFileNameWithoutExtension(fa.fileName) == projName)
                {
                    string strEx = Path.GetExtension(fa.fileName);
                    resultStr = strEx + "  " + fa.description;
                    break;
                }
            }
            return resultStr;
        }

        private void FolderComparator()
        {
            //       string nameFileA;
            //       string sizeFileA;
            FileAttrib fA = new FileAttrib();
            // запускаем поиск файлов расположенных в текущем каталоге. с учетом подкаталогов. 
         
            string[] allfilesA = Directory.GetFiles(filesPathCompilling, "*.*", SearchOption.AllDirectories);
            FilesWork.Clear();
            FilesCompiling.Clear(); 
            // возникает ошибка при индексировании. 
            // Нужно проводить индексирование файлов в каждома каталоге
            // Добавлять в каталог файл сразу при получении его имени.
            // При ошибке доступа к каталогу выводить соответствующее исключение. 
            // выводить разрешение файла

            for (int indexA = 0; indexA < allfilesA.Length; indexA++)
            {
                fA.fileName = Path.GetFileName(allfilesA[indexA]);
                System.IO.FileInfo fi = new FileInfo(allfilesA[indexA]);
                fA.fileSize = fi.Length;
                // добавляем файлы в массив.
                string strEx = Path.GetExtension(allfilesA[indexA]);
                if (strEx != ".cs")
                    FilesCompiling.Add(fA);
            }
            string[] allfilesB = Directory.GetFiles(filesPathWork, "*.*", SearchOption.AllDirectories);

            for (int indexB = 0; indexB < allfilesB.Length; indexB++)// foreach (string filename in allfilesB)
            {
                fA.fileName = Path.GetFileName(allfilesB[indexB]);
                System.IO.FileInfo fi = new FileInfo(allfilesB[indexB]);
                fA.fileSize = fi.Length;// (allfilesB[indexB]).Length; //attributes. File.filу (allfilesB[indexB]);//. e.GetAttributes.Si System.IO.
                // добавляем файлы в массив.
                if (Path.GetExtension(allfilesB[indexB]) != ".cs")
                    FilesWork.Add(fA);
            }

            long index = 0;

            for (int indexB = 0; indexB < FilesWork.Count; indexB++)
            {
                for (int indexA = 0; indexA < FilesCompiling.Count; indexA++)
                {
                    if (FilesCompiling[indexA].fileName == FilesWork[indexB].fileName)
                    {
                        if (FilesCompiling[indexA].fileSize != FilesWork[indexB].fileSize)
                        {
                            index++;
                            fA.fileName = FilesWork[indexB].fileName;
                            fA.fileSize = FilesWork[indexB].fileSize;
                            fA.description = (FilesWork[indexB].fileSize - FilesCompiling[indexA].fileSize).ToString();
                            FilesWork[indexB] = fA; 
                            tbLog.AppendText(index.ToString() + " " + FilesWork[indexB].fileName + "\t" + FilesWork[indexB].description+"\r\n");

                            //   dGvFileList[3, dGvFileList.Rows.Count - 1].Value = ;
                        }
                        else
                        {
                            fA.description = "==="; // (FilesWork[indexB].fileSize - FilesCompiling[indexA].fileSize).ToString();
                            fA.fileName = FilesWork[indexB].fileName;
                            fA.fileSize = FilesWork[indexB].fileSize;
                            FilesWork[indexB] = fA;
                        }
                        continue;
                    }
                }
            }


            int matches = 0;   

          for (int indexB = 0; indexB < FilesWork.Count; indexB++)
            {
                matches = 0;
                for (int indexA = 0; indexA < FilesCompiling.Count; indexA++)
                {
                    if (FilesCompiling[indexA].fileName == FilesWork[indexB].fileName)
                    {
                        matches++;
                    }
                }

                if (matches == 0)
                {
                    index++;
                    fA.description = "P---"; 
                    fA.fileName = FilesWork[indexB].fileName;
                    fA.fileSize = FilesWork[indexB].fileSize;
                    FilesWork[indexB] = fA;
                    tbLog.AppendText(index.ToString() + " " + FilesWork[indexB].fileName + "\t" + FilesWork[indexB].description+"\r\n");
                }
            }
//            label1.Text = "Вывод результата";
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // проводим сравнение файлов в каталогах. 
            // определяем разницу в размерах файлов в проектах и их наличие. 
            //    
            FolderComparator();
            btnProjTree.Enabled = true; 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDialogFileA = new FolderBrowserDialog();
            if (fbDialogFileA.ShowDialog() == DialogResult.OK)
            {
                filesPathCompilling = fbDialogFileA.SelectedPath;
                tbCompillngFolder.Text = filesPathCompilling;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDialogFileB = new FolderBrowserDialog();
            if (fbDialogFileB.ShowDialog() == DialogResult.OK)
            {
              filesPathWork = fbDialogFileB.SelectedPath;
              tbWorkFolder.Text = filesPathWork;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           if (filesPathProject!="")
            {
              tbLog.Text = "";
              SolutionAnalize(filesPathProject);
            }
        }
        // Производит поиск проектов не входящих ни водно решение.   
    }
}
