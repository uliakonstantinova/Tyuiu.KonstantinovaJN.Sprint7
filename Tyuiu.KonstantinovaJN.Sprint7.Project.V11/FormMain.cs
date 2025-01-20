using System.Data;
using System.Text;
using System.Windows.Forms;
using Tyuiu.KonstantinovaJN.Sprint7.Project.V9;
using Tyuiu.KonstantinovaJN.Sprint7.Project.V9.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint7.Project.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }
        DataService ds = new DataService();
        static string openFilePathFilms;
        DataTable _dtFilms;

        private void buttonOpenFile_KJN_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePathFilms = openFileDialogTask.FileName;
            DataTable dt = ds.ConvertCSVtoDataTable(openFilePathFilms);
            dataGridViewFilms_KJN.DataSource = dt;
            _dtFilms = dt.Copy();
        }

        private void buttonSaveToFileFilms_KJN_Click(object sender, EventArgs e)
        {
            string csv = "";

            foreach (DataGridViewColumn column in dataGridViewFilms_KJN.Columns)
            {
                csv += column.HeaderText + ';';
            }
            csv = csv.TrimEnd(';') + "\r\n";

            foreach (DataGridViewRow row in dataGridViewFilms_KJN.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        csv += cell.Value.ToString() + ';';
                    }

                }
                csv = csv.TrimEnd(';') + "\r\n";
            }
            csv = csv.Substring(0, csv.Length - 4);
            File.WriteAllText(openFilePathFilms, csv, Encoding.GetEncoding(1251));
        }

        private void buttonLoadActorsByFilm_KJN_Click(object sender, EventArgs e)
        {
            string FilePathActors = Path.Combine(Path.GetDirectoryName(openFilePathFilms), "актеры.csv");
            DataTable dtActors = ds.ConvertCSVtoDataTable(FilePathActors);
            DataTable dtActorsByFilter = dtActors.Copy();
            dtActorsByFilter.Clear();
            string idFilm = dataGridViewFilms_KJN.SelectedCells[0].Value.ToString();

            foreach (DataRow dr in dtActors.Rows)
            {
                if (dr.ItemArray[0].ToString() == idFilm)
                {
                    dtActorsByFilter.Rows.Add(dr.ItemArray);
                }
            }
            if (dtActorsByFilter.Rows.Count > 0)
            {
                dataGridViewActors_KJN.DataSource = dtActorsByFilter;
            }
            else
            {
                MessageBox.Show("Актеров в выбранном фильме не найдено.");
            }
        }

        private void textBoxFilter_KJN_TextChanged(object sender, EventArgs e)
        {
            string cbFilter = comboBoxFilter_KJN.Text;
            string tbFilter = textBoxFilter_KJN.Text;
            DataTable dtFilmsByFilter = _dtFilms.Copy();
            dtFilmsByFilter.Clear();

            if (cbFilter != "" && tbFilter != "")
            {
                foreach (DataRow dr in _dtFilms.Rows)
                {
                    if (dr[cbFilter].ToString() == tbFilter)
                    {
                        dtFilmsByFilter.Rows.Add(dr.ItemArray);
                    }
                }
                if (dtFilmsByFilter.Rows.Count > 0)
                {
                    dataGridViewFilms_KJN.DataSource = dtFilmsByFilter;
                }
                buttonSaveToFileFilms_KJN.Enabled = false;
            }
            else
            {
                dataGridViewFilms_KJN.DataSource = _dtFilms;
                buttonSaveToFileFilms_KJN.Enabled = true;
            }
        }

        private void buttonOpenFormStatistic_KJN_Click(object sender, EventArgs e)
        {
            FormStatistic formStatistic = new FormStatistic();
            formStatistic.ShowDialog();
        }

        private void buttonHelp_KJN_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
