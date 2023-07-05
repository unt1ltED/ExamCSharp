using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCSharp
{
    public partial class earnings : Form
    {
        EarningsController earningsController;
        List<List<List<Work>>> jobs;
        public earnings(string username)
        {
            InitializeComponent();
            jobs = new List<List<List<Work>>>();
            //User user = new User("bebra", "Poroshenko228");
            //List<Work> works = new List<Work>()
            //{
            //    new Work("zakladka", 1000, new DateTime(2022, 5, 19)),
            //    new Work("bazar", 500, new DateTime(2023, 6, 23)),
            //};
            //List<Work> works2 = new List<Work>()
            //{
            //    new Work("main job", 10000, new DateTime(2023, 5, 20)),
            //    new Work("main job", 10000, new DateTime(2023, 6, 26)),
            //};

            //user.MainJobs = works2;
            //user.Additional = works;
            //using (FileStream f = new FileStream("bebra//user.json", FileMode.OpenOrCreate))
            //{
            //    JsonSerializer.Serialize<User>(f, user);
            //}
            earningsController = new EarningsController(username);
            Display();

        }
        
        private void Display()
        {
            List<Work>? earnings = earningsController.GetEarnings();
            if(earnings == null)
            {
                MessageBox.Show("no earnings");
                return;
            }

            earnings.Reverse();
            treeView1.Nodes.Clear();
            foreach(Work work in earnings)
            {
                if(treeView1.Nodes.Count == 0
                    || treeView1.Nodes[treeView1.Nodes.Count - 1].Text != work.Date.Year.ToString())
                {
                    treeView1.Nodes.Add(new TreeNode(work.Date.Year.ToString()));
                    jobs.Add(new List<List<Work>>());
                    //yearIndex = treeView1.Nodes.Count - 1;
                }

                if (treeView1.Nodes[treeView1.Nodes.Count - 1].Nodes.Count == 0
                    || treeView1.Nodes[treeView1.Nodes.Count - 1].Nodes[treeView1.Nodes[treeView1.Nodes.Count - 1].Nodes.Count - 1].Text != work.Date.ToString("MMMM"))
                {
                    treeView1.Nodes[treeView1.Nodes.Count - 1].Nodes.Add(work.Date.ToString("MMMM"));
                    jobs[jobs.Count - 1].Add(new List<Work>());
                }

                treeView1.Nodes[treeView1.Nodes.Count - 1].Nodes[treeView1.Nodes[treeView1.Nodes.Count - 1].Nodes.Count - 1].Nodes.Add(new TreeNode(work.Name));
                jobs[jobs.Count - 1][jobs[jobs.Count - 1].Count - 1].Add(work);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            // Check if a node is selected
            if (selectedNode != null)
            {
                // Process the selected node
                string selectedNodeText = selectedNode.Text;
                MessageBox.Show("Selected Node: " + selectedNodeText);
            }
        }
    }
}
