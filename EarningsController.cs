using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExamCSharp
{
    internal class EarningsController : UserController
    {
        private List<Work> mainJobs;
        public List<Work> MainJobs
        {
            get => mainJobs;
        }
        private List<Work> additional;
        public List<Work> Additional
        {
            get => additional;
        }

        public EarningsController(string username) : base(username)
        {
            GetFromFile();
        }

        private void SerializeMainJobs()
        {
            string mainJobsPath = filePath + "\\mainJobs,json";
            using (FileStream f = new FileStream(mainJobsPath, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<List<Work>>(f, mainJobs);
            }
        }

        private void SerializeAdditional()
        {
            string additionalPath = filePath + "\\additional.json";
            using (FileStream f = new FileStream(additionalPath, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<List<Work>>(f, additional);
            }
        }

        private void GetFromFile()
        {
            string mainJobsPath = filePath + "\\mainJobs.json";
            if (File.Exists(mainJobsPath))
            {
                using (FileStream f = new FileStream(mainJobsPath, FileMode.Open))
                {
                    mainJobs = JsonSerializer.Deserialize<List<Work>>(f);
                }
            }
            else if (user.MainJobs.Count != 0)
            {
                mainJobs = user.MainJobs;
                SerializeMainJobs();
            }
            else
                mainJobs = new List<Work>();

            string additionalPath = filePath + "\\additional.json";
            if (File.Exists(additionalPath))
            {
                using (FileStream f = new FileStream(additionalPath, FileMode.Open))
                {
                    additional = JsonSerializer.Deserialize<List<Work>>(f);
                }
            }
            else if (user.Additional.Count != 0)
            {
                additional = user.Additional;
                SerializeAdditional();
            }
            else
                additional = new List<Work>();
        }
        public void DeleteJob(int index)
        {
            mainJobs.RemoveAt(index);
            SerializeMainJobs();
        }

        public void AddMainJob(string name, double amount, DateTime date)
        {
            mainJobs.Add(new Work(name, amount, date));
            SerializeMainJobs();
        }

        public void ChangeSalary(int index, double newSalary)
        {
            mainJobs[index].Amount = newSalary;
            SerializeMainJobs();
        }

        public void AddAdditional(string name, double amount, DateTime date)
        {
            additional.Add(new Work(name, amount, date));
            SerializeAdditional();
        }

        //public List<List<List<Work>>> GetSorted()
        //{
        //    List<List<List<Work>>> works = new List<List<Work>>;
        //    foreach(Work work in mainJobs)
        //    {
        //        int year = work.Date.Year;
        //        int month = work.Date.Month;
        //        int day = work.Date.Day;
                
        //        int yearIndex = -1;
        //        for (int i = 0; i < works.Count; i++)
        //        {
        //            if (works[i][0][0].Date.Year == year)
        //            {
        //                yearIndex = i;
        //                break;
        //            }
        //        }

        //        if(yearIndex == -1)
        //        {
        //            if (works.Count == 0)
        //            {
        //                yearIndex = 0;
        //            }
        //            else
        //            {
        //                for (int i = 0; i < works.Count; i++)
        //                {
        //                    if (i != 0 && works[i - 1][0][0].Date.Year == year - 1)
        //                    {
        //                        yearIndex = i;
        //                        break;
        //                    }

        //                    if (i + 1 != works.Count && works[i + 1][0][0].Date.Year == year + 1)
        //                    {
        //                        yearIndex = i + 1;
        //                        break;
        //                    }
        //                }

        //                if(yearIndex == -1)
        //                {
        //                    if(year < works)
        //                }
        //            }

        //            works.Insert(yearIndex, new List<List<Work>>());
        //        }

                

        //        int monthIndex = -1;
        //        for (int i = 0; i < works[yearIndex].Count; i++)
        //        {
        //            if (works[yearIndex][i][0].Date.Month == month)
        //            {
        //                month = i;
        //                break;
        //            }
        //        }

        //        if(monthIndex == -1)
        //        {
        //            if (works[yearIndex].Count == 0)
        //            {
        //                monthIndex = 0;
        //                break;
        //            }
        //        }
        //        if(monthIndex == -1)
        //        {
        //            if(works[yearIndex].Count == 0)
        //            {
        //                monthIndex = 0;
        //            }
        //            else
        //            {
        //                for (int i = 0; i < works[yearIndex].Count; i++)
        //                {
        //                    if()
        //                }
        //            }
        //        }
        //        if(works.Any(year => year[0][0].Date.Year == currentYear))
        //        {
        //            if(works.Any(year => year[0][0].Date.Month == currentMonth))
        //        }
        //    }
        //}

        public List<Work>? GetEarnings()
        {
            if(mainJobs.Count == 0)
            {
                if (additional.Count != 0)
                    return additional;
                else 
                    return null;
            }
            List<Work> combined = new List<Work>(mainJobs);
            foreach(Work work in additional)
            {
                for (int i = 0; i < combined.Count; i++)
                {
                    if(i != 0 && i != combined.Count - 1)
                    {
                        if (combined[i].Date <= work.Date
                            && combined[i + 1].Date >= work.Date)
                        {
                            combined.Insert(i + 1, work);
                            break;
                        }
                    }
                    if(i == 0 && work.Date <= combined[i].Date)
                    {
                        combined.Insert(0, work);
                        break;
                    }
                    if(i == combined.Count - 1 && work.Date >= combined[i].Date)
                    {
                        combined.Add(work);
                        break;
                    }
                }
            }
            return combined;
        }
    }
}
