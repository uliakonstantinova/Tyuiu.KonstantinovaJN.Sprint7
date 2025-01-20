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
using Tyuiu.KonstantinovaJN.Sprint7.Project.V9.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint7.Project.V9
{
    public partial class FormStatistic : Form
    {
        public FormStatistic()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void FormStatistic_Load(object sender, EventArgs e)
        {
            this.chartFunction.ChartAreas[0].AxisX.Title = "Год выхода";
            this.chartFunction.ChartAreas[0].AxisY.Title = "Количество фильмов";
            DataTable dtFilms = ds.ConvertCSVtoDataTable("фильмы.csv");
            chartFunction.Series[0].Points.Clear();

            dtFilms.DefaultView.Sort = "Год выхода";
            DataTable dtYears = dtFilms.DefaultView.ToTable(true, "Год выхода");

            int[] cntFilms = new int[dtYears.Rows.Count];
            for (int i = 0; i < dtYears.Rows.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < dtFilms.Rows.Count; j++)
                {
                    if (dtFilms.Rows[j]["Год выхода"].ToString() == dtYears.Rows[i]["Год выхода"].ToString())
                    {
                        count++;
                    }
                }

                cntFilms[i] = count;
            }

            for (int i = 0; i < cntFilms.Length; i++)
            {
                chartFunction.Series[0].Points.AddXY(Convert.ToInt32(dtYears.Rows[i]["Год выхода"]), cntFilms[i]);
            }
        }
    }
}
