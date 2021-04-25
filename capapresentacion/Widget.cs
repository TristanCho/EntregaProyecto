using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Timers;

namespace capapresentacion
{
    public partial class Widget : Form
    {
        //Stopwatch cronometro = new Stopwatch();
        System.Timers.Timer temporizador;
        int hora, minuto, segundo;

        SqlConnection con = new SqlConnection("Data Source=MSI\\SQLMSI;Initial Catalog=IlernaV2;Integrated Security=False;User Id=winplus;Password=Pbjjajlp5h4m1");
        // SqlConnection con = new SqlConnection("Data Source=PCCRISTHIAN\\SQLEXPRESS;Initial Catalog=IlernaV2;Integrated Security=False;User Id=winplus;Password=Pbjjajlp5h4m1");
        
        public Widget()
        {
            InitializeComponent();
            convertirWidget();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            //String id = comboBox1.Text;
            //Con esto puedes sacas el nombre del proyecto que señalas en el combobox,y al clicarlo te da su codigo con el cual luego haces una consulta sobre los proyectos
            try
            {
                
                con.Open();
                SqlCommand query = new SqlCommand("select descripcion from Proyectos p inner join TareasPersonales_Tareas tpt on "+ comboBox1.SelectedValue + "=tpt.idProyecto inner join Tareas t on t.id=tpt.idTareaProyecto", con);

                //SqlCommand query = new SqlCommand("select codigo from Personal where codigo='" + comboBox1.SelectedValue.ToString()+"'", con);

                SqlDataReader reader;
                reader = query.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Columns.Add("descripcion", typeof(string));
                dt.Columns.Add("codigo", typeof(string));


                //dt.Columns.Add("codigo", typeof(string));

                dt.Load(reader);



                comboBox2.ValueMember = "descripcion";
                //comboBox2.ValueMember = "codigo";

                comboBox2.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

            }*/
        }

        private void Form1_Load(object sender, EventArgs e)

        {   /*Cronometro*/
            temporizador = new System.Timers.Timer();
            temporizador.Interval = 1000;
            temporizador.Elapsed += OnTimeEvent;
            /*Cronometro*/

            try
            {
                con.Open();
               SqlCommand query = new SqlCommand("SELECT* FROM Tareas order by fecha_creacion desc", con);
            

                SqlDataReader reader;
                reader = query.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("titulo", typeof(string));
                ///dt.Columns.Add("descripcion", typeof(string));
                //dt.Columns.Add("id", typeof(string));
                //dt.Columns.Add("titulo", typeof(string));

                //dt.Columns.Add("codigo", typeof(string));
                //dt.Columns.Add("nombre", typeof(string));
                dt.Load(reader);


                //listaTareasPersonales.ValueMember = "descripcion";
                listaTareasPersonales.DisplayMember = "titulo";
                ///listaTareasPersonales.DisplayMember = "descripcion";

                //comboBox1.ValueMember = "codigo";
                //comboBox1.DisplayMember = "nombre";

                listaTareasPersonales.DataSource = dt;

                //Console.WriteLine(comboBox1.SelectedValue);
                con.Close();
            }
            catch (Exception)
            {

            }


            /*
            try
            {
                con.Open();
                SqlCommand query = new SqlCommand("select id,titulo from Proyectos", con); 

                //SqlCommand query = new SqlCommand("select codigo,nombre from Personal", con);

                SqlDataReader reader;
                reader = query.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Columns.Add("id", typeof(string));
                dt.Columns.Add("titulo", typeof(string));

                //dt.Columns.Add("codigo", typeof(string));
                //dt.Columns.Add("nombre", typeof(string));
                dt.Load(reader);


                comboBox1.ValueMember = "id";
                comboBox1.DisplayMember = "titulo";
               
                //comboBox1.ValueMember = "codigo";
                //comboBox1.DisplayMember = "nombre";

                comboBox1.DataSource = dt;

                //Console.WriteLine(comboBox1.SelectedValue);
                con.Close();
            }
            catch (Exception)
            {

            }*/
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
            segundo += 1;
            if (segundo == 60)
            {
                segundo = 0;
                minuto += 1;
            }
            if (minuto == 60)
            {
                minuto = 0;
                hora += 1;
            }
            tCronometro.Text = string.Format("{0}:{1}:{2}",hora.ToString().PadLeft(2, '0'), minuto.ToString().PadLeft(2, '0'),segundo.ToString().PadLeft(2, '0'));
            }));//TODO me ha saltado error cuando desde el widget pongo a rodar el tiempo y luego maximizo el formulario
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
 
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        MessageBox.Show("doble click derecho");
                    }
                    break;
            }
            WindowState = FormWindowState.Normal;
        }

        private void convertirWidget()
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            TopMost = true;
            ShowInTaskbar = false;
            this.Text = String.Empty;
            this.ControlBox = false;
            moverVentanaAbajoDerecha();
            
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            this.Close();
            frmPrincipal.Show();
        }

        private void miminizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void moverVentanaAbajoDerecha()
        {

            Screen rightmost = Screen.AllScreens[0];
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.Right > rightmost.WorkingArea.Right)
                    rightmost = screen;
            }

            this.Left = rightmost.WorkingArea.Right - this.Width;
            this.Top = rightmost.WorkingArea.Bottom - this.Height;
        }



        private void botonApagar_Click(object sender, EventArgs e)
        {
            pararCronometro();
           // MessageBox.Show("Horas hechas : " + calculaHoras(hora_inicio, hora_fin));
        }
        private TimeSpan calculaHoras(TimeSpan hora_inicio, TimeSpan hora_fin)
        {
            return hora_fin - hora_inicio;
        }
        private void botonStart_Click(object sender, EventArgs e)
        {
            iniciaCronometro();
            
        }

        private void iniciaCronometro()
        {
            temporizador.Start();
            /*
            if (listaTareasPersonales.SelectedItem != null)
            {
                //cronometro.Start();
                //temporizador.Enabled = true;

               // hora_inicio = DateTime.Now.TimeOfDay;
                //fecha_inicio = DateTime.Now.ToLongDateString();

                // Con este update lo que haremos mas adelante será preguntar si la fecha actual es mayor a la fecha insertada
                // ya que si no cada vez que cliquemos al boton start la fecha de inicio cambiara
                con.Open();
                SqlCommand cmd = new SqlCommand(" UPDATE tt SET tt.fechaInicio=CURRENT_TIMESTAMP from Proyectos p  inner join Tareas t on p.id="+ comboBox1.SelectedValue + " inner join Tiempos_tarea tt on tt.id_tarea=t.id", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }*/
        }

        private void pararCronometro()
        {
            temporizador.Stop();
            //cronometro.Stop();
            /*
            con.Open();
            SqlCommand cmd = new SqlCommand(" UPDATE tt SET tt.fechaFin=CURRENT_TIMESTAMP from Proyectos p  inner join Tareas t on p.id=" + comboBox2.SelectedValue + "  inner join Tiempos_tarea tt on tt.id_tarea=t.id", con);
            cmd.ExecuteNonQuery();
            con.Close();

            hora_fin = DateTime.Now.TimeOfDay;
            fecha_fin = DateTime.Now.ToLongDateString();
            */
        }
        /*
        private void temporizador_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)cronometro.ElapsedMilliseconds);

            thora.Text = ts.Hours.ToString().Length < 2 ? "0" + ts.Hours.ToString() : ts.Hours.ToString();
            tminuto.Text = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            tsegundo.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();

        }
        */
        private void modoAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            this.Close();
            frmPrincipal.Show();
        }

        /*Utilizado para mover el panel atraves de la pantalla*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iniciarCronometroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaCronometro();
        }

        private void pararCronometroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pararCronometro();
        }

        private void tCronometro_TextChanged(object sender, EventArgs e)
        {

        }
        /*fin del drag*/
    }
}
