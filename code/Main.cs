using System.Collections;
using System.Diagnostics;

namespace WebBrowserSelector
{
    public partial class Main : Form
    {
        string nowDir = Directory.GetCurrentDirectory();
        StreamReader sr; StreamWriter sw;

        private ArrayList exeProfile = new ArrayList();
        private void UpdateComponent()
        {
            try
            {
                string name;
                sr = new StreamReader(nowDir + @"\setting\amount.axset");
                int num = Convert.ToInt32(sr.ReadLine());
                sr.Close();

                for (int i = 0; i <= num; i++)
                {
                    sr = new StreamReader(nowDir + @"\src\" + i.ToString() + @"\name.axset");
                    name = sr.ReadLine();
                    sr.Close();
                    exeProfile.Add(new DictionaryEntry(name, i));
                }
            }
            catch
            {
                MessageBox.Show("There are some unknown errors. Please resetup this application!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Close();
            }

        }

        public Main()
        {
            InitializeComponent();
            UpdateComponent();

            list.DisplayMember = "Key";
            list.ValueMember = "Value";
            list.DataSource = exeProfile;
        }

        private void run_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void KeyPress_Run(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 108 || e.KeyChar == 13)
            {
                Open();
            }
        }

        private void Open()
        {
            string name, exe, par;
            sr = new StreamReader(nowDir + @"\src\" + list.SelectedValue.ToString() + @"\name.axset");
            name = sr.ReadLine(); sr.Close();
            sr = new StreamReader(nowDir + @"\src\" + list.SelectedValue.ToString() + @"\exe.axset");
            exe = sr.ReadLine(); sr.Close();
            sr = new StreamReader(nowDir + @"\src\" + list.SelectedValue.ToString() + @"\parameter.axset");
            par = sr.ReadLine(); sr.Close();

            Process.Start(exe, par);

            if (list.SelectedValue.ToString() != "0")
            {
                sw = new StreamWriter(nowDir + @"\src\0\name.axset");
                sw.WriteLine("最近使用 - " + name); sw.Close();
                sw = new StreamWriter(nowDir + @"\src\0\exe.axset");
                sw.WriteLine(exe); sw.Close();
                sw = new StreamWriter(nowDir + @"\src\0\parameter.axset");
                sw.WriteLine(par); sw.Close();
            }

            Close();
        }
    }
}
