using Stimulsoft.Report;
using Stimulsoft.Winform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stimulsoft.Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string directory = AppDomain.CurrentDomain.BaseDirectory;
            var str = Path.Combine(Application.StartupPath, "Reports", "report.mrt");

            initializeModels(out Models.Label label, out LabelName labelName);

            var report = new StiReport();

            report.RegBusinessObject("label", label);
            report.RegBusinessObject("labelName", labelName);

            report.Load(str);

            report.Design();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            initializeModels(out Models.Label label, out LabelName labelName);

            var report = new StiReport();

            report.RegBusinessObject("label", label);
            report.RegBusinessObject("labelName", labelName);

            report.Load("Report.mrt");

            report.Show();
        }
        private static void initializeModels(out Models.Label label, out LabelName labelName)
        {
            label = new Models.Label
            {
                Prop0 = "geforce rtx 3060",
                Prop1 = "John smit",
            };
            labelName = new LabelName
            {
                Prop0 = "Product:‌",
                Prop1 = "Customer:",
            };
        }
    }
}
