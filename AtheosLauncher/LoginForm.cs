namespace AtheosLauncher
{
    using ManualMapInjection.Injection;
    using MySql.Data.MySqlClient;
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;


    public partial class LoginForm : Form
    {
        private const int WM_NCHITTEST = 0x84;

        private const int HTCLIENT = 0x1;

        private const int HTCAPTION = 0x2;

        private MySqlConnection conn;

        internal string HWID;

        public LoginForm()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = String.Empty;
            HWID = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
            string connString;
            connString = $"SERVER=159.89.29.56;PORT=3306;DATABASE=atheoscheat;UID=root;PASSWORD=5603;Connect Timeout=10";
            conn = new MySqlConnection(connString);
            foreach (Process process in Process.GetProcessesByName("steam"))
            {
                process.Kill();
            }
            InitializeComponent();
            close.MouseEnter += OnMouseEnterClose;
            close.MouseLeave += OnMouseLeaveClose;
        }

        private void loadingfunc(object sender, EventArgs e)
        {
            checkdb();
            checkdll();
        }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        private void OnMouseEnterClose(object sender, EventArgs e)
        {
            close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
        }

        private void OnMouseLeaveClose(object sender, EventArgs e)
        {
            close.ForeColor = Color.White;
        }

        private void closefunc(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        public bool verifylogin()
        {
            MySqlTransaction verifylogintrans;
            string queryusernamepassword = $"SELECT * FROM loader WHERE username = '{username.Text}' AND password = '{password.Text}';";
            if (startmysqlconnection())
            {
                MySqlCommand cmd = new MySqlCommand(queryusernamepassword, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string hwidverifier = reader.GetValue(2).ToString();
                    reader.Close();
                    string queryhwid = $"SELECT * FROM loader WHERE username = '{username.Text}' AND hwid = '{HWID}';";
                    cmd = new MySqlCommand(queryhwid, conn);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        reader.Close();
                        string queryplan = $"SELECT * FROM loader WHERE username = '{username.Text}' AND active_subscription = true;";
                        cmd = new MySqlCommand(queryplan, conn);
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            reader.Close();
                            conn.Close();
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No subscription found.", "Subscription Error");
                            reader.Close();
                            conn.Close();
                            return false;
                        }

                    }
                    else
                    {
                        if (hwidverifier == "")
                        {
                            reader.Close();
                            verifylogintrans = conn.BeginTransaction();
                            cmd.CommandText = $"UPDATE loader SET hwid = '{HWID}' WHERE username = '{username.Text}';";
                            cmd.ExecuteNonQuery();
                            verifylogintrans.Commit();
                            MessageBox.Show("HWID defined.", "HWID Info");
                            string queryplan = $"SELECT * FROM loader WHERE username = '{username.Text}' AND active_subscription = true;";
                            cmd = new MySqlCommand(queryplan, conn);
                            reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                reader.Close();
                                conn.Close();
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("No subscription found.", "Subscription Error");
                                reader.Close();
                                conn.Close();
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid HWID.", "HWID Error");
                            reader.Close();
                            conn.Close();
                            return false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password incorrect.", "Credentials Error");
                    reader.Close();
                    conn.Close();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Error while connecting to database.", "Internal Error");
                conn.Close();
                return false;
            }
        }

        private bool startmysqlconnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void loginfunc(object sender, EventArgs e)
        {
            if(resultmysql == false)
            {
                MessageBox.Show("Cannot connect to database to verify login.", "Internal Error");
                System.Environment.Exit(0);
            }
            else if(statusservercheat == false)
            {
                MessageBox.Show("Cannot connect to cheat downloader.", "Internal Error");
                System.Environment.Exit(0);
            }
            WebClient wb = new WebClient();
            if (verifylogin())
            {
                hex.ForeColor = Color.Yellow;
                hex.Text = "Injecting...";
                System.Diagnostics.Process.Start("steam://run/730/");
                this.Hide();
                byte[] file = wb.DownloadData("http://159.89.29.56/AtheosCheat.dll");

                Thread.Sleep(15000);
                var nameprogram = "csgo";
                var targetProcess = Process.GetProcessesByName(nameprogram).FirstOrDefault();

                var injector = new ManualMapInjector(targetProcess) { AsyncInjection = true };
                hex.Text = $"hmodule = 0x{injector.Inject(file).ToInt64():x8}";
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        public bool resultmysql;

        public void checkdb()
        {
            using (var client = new WebClient())
            {
                MySqlConnection connection = new MySqlConnection("Database=atheoscheat;Data Source=159.89.29.56;User Id=root;Password=5603;Connect Timeout=10");
                try
                {
                    connection.Open();
                    connection.Close();
                    resultmysql = true;
                }
                catch(MySqlException e)
                {
                    MessageBox.Show($"{e}");
                    resultmysql = false;
                }
                if (resultmysql == true)
                {
                    dbstatusresult.Text = "Online";
                    dbstatusresult.ForeColor = Color.LightGreen;
                }
                else
                {
                    dbstatusresult.Text = "Offline";
                    dbstatusresult.ForeColor = Color.Red;
                }
            }
        }

        public bool statusservercheat;

        private void checkdll()
        {
            using (var client = new WebClient())
            {
                try
                {
                    using (client.OpenRead("http://159.89.29.56/"))
                    {
                        cheatstatusresult.Text = "Online";
                        cheatstatusresult.ForeColor = Color.LightGreen;
                        statusservercheat = true;
                    }
                }
                catch
                {
                    cheatstatusresult.Text = "Offline";
                    cheatstatusresult.ForeColor = Color.Red;
                    statusservercheat = false;
                }
            }
        }

        private void nomeprogramafunc(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/4Da9m9cvTq");
        }
    }
}
