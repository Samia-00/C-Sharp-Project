using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_database_project
{
    class Student
    {
        string sId = "";
        string name = "";
        string sAdress = "";
        double bangla = 0;
        double english = 0;
        double math = 0;

        public string studentId
        {
            set
            {
                sId = value;
            }
            get
            {
                return sId;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public double MarksofBangla
        {
            set
            {
                bangla = value;
            }
            get
            {
                return bangla;
            }
        }
        public double MarksofEnglish
        {
            set
            {
                english = value;
            }
            get 
            {
                return english;
            }
        }
        public double MarksofMath
        {
            set
            {
                math = value;
            }
            get
            {
                return math;
            }
        }
        public double AvgMarks()
        {
            
                return (bangla+english+math)/3;
        }
        public void Save()
        {
            FileStream fs = new FileStream(@"F:\c# project\server project\"+sId+".txt",FileMode.Create,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(sId);
            sw.WriteLine(bangla);
            sw.WriteLine(english);
            sw.WriteLine(math);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public void Find()
        {
            FileStream fs = new FileStream(@"F:\c# project\server project\" + sId + ".txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sId = sr.ReadLine();
            bangla = Convert.ToDouble(sr.ReadLine());
            english =Convert.ToDouble(sr.ReadLine());
            math = Convert.ToDouble(sr.ReadLine());
            sr.Close();
            fs.Close();
        }

    }
}
