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
using System.IO;
using System.Drawing.Imaging;

namespace $safeprojectname$
{
    public partial class frmCRUD : Form
    {
        Bitmap bmp;
        public frmCRUD()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=valorant;Data Source=DESKTOP-KM7D9PT";
        private string strSql = string.Empty;
        //private string strSql1 = string.Empty;
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != null && txtNome.Text != null && cmbClasse.Text != null && mtbRecrutamento.Text != null && bmp != null && picImagem != null)
            {



                MemoryStream memory = new MemoryStream();

                bmp.Save(memory, ImageFormat.Bmp);

                byte[] foto = memory.ToArray();




                strSql = "INSERT INTO Agente (Id_agente, Nome_agente, Titulo_agente, Classe, Nacionalidade, Imagem, Recrutamento) VALUES (@Id_agente, @Nome_agente, @Titulo_agente, @Classe, @Nacionalidade, @Imagem, @Recrutamento)";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.Add("Id_agente", SqlDbType.Int).Value = txtID.Text;
                comando.Parameters.Add("Nome_agente", SqlDbType.VarChar).Value = txtNome.Text;
                comando.Parameters.Add("Titulo_agente", SqlDbType.VarChar).Value = txtTitulo.Text;
                comando.Parameters.Add("Classe", SqlDbType.VarChar).Value = cmbClasse.Text;
                comando.Parameters.Add("Nacionalidade", SqlDbType.VarChar).Value = txtNacionalidade.Text;
                comando.Parameters.Add("Imagem", SqlDbType.Binary).Value = foto;
                comando.Parameters.Add("Recrutamento", SqlDbType.Date).Value = mtbRecrutamento.Text;

                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Agente recrutado com sucesso!");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    sqlCon.Close();
                }
            }
            else
            {
                lblErro.Text = "Somente o Título e a Nascionalidade podem ser vazios!";

            }

                tsbNovo.Enabled = true;
                btnSalvar.Enabled = false;
                tsbAlterar.Enabled = false;
                btnBrowser.Enabled = false;
                tsbExcluir.Enabled = false;
                tstBuscar.Enabled = true;
                tsbSearch.Enabled = true;
                txtID.Enabled = false;
                txtNome.Enabled = false;
                txtTitulo.Enabled = false;
                cmbClasse.Enabled = false;
                txtNacionalidade.Enabled = false;
                txtID.Clear();
                txtNome.Clear();
                txtTitulo.Clear();
                cmbClasse.Text = "";
                txtNacionalidade.Clear();
                picImagem.Image = null;
                mtbRecrutamento.Clear();
                picImagem.Enabled = false;
                mtbRecrutamento.Enabled = false;

            
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            strSql = "SELECT * FROM Agente WHERE Id_agente = @Id_agente"; 
            //strSql1 = "SELECT * FROM Agente WHERE Nome_agente = @Nome_agente";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            //SqlCommand comando1 = new SqlCommand(strSql1, sqlCon);

            comando.Parameters.Add("@Id_agente", SqlDbType.Int).Value = tstBuscar.Text;
            //comando.Parameters.Add("@Nome_agente", SqlDbType.VarChar).Value = tstBuscar.Text;

            try
            {
                if (tstBuscar.Text == string.Empty)
                {
                    throw new Exception("Digite o Id ou o Nome do agente à procura.");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows == false)
                {
                    throw new Exception("Agente não cadastrado.");                  
                }
                dr.Read();
                txtID.Text = Convert.ToString(dr["Id_agente"]);
                txtNome.Text = Convert.ToString(dr["Nome_agente"]);
                txtTitulo.Text = Convert.ToString(dr["Titulo_agente"]);
                cmbClasse.Text = Convert.ToString(dr["Classe"]);
                txtNacionalidade.Text = Convert.ToString(dr["Nacionalidade"]);
                byte[] imagem = (byte[])(dr["Imagem"]);
                mtbRecrutamento.Text = Convert.ToString(dr["Recrutamento"]);
                if (imagem == null)
                {
                    picImagem.Image = null;
                }
                else
                {
                    MemoryStream memory = new MemoryStream(imagem);
                    picImagem.Image = Image.FromStream(memory);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            tsbNovo.Enabled = false;
            btnSalvar.Enabled = false;
            tsbAlterar.Enabled = true;
            tsbExcluir.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbSearch.Enabled = true;
            tstBuscar.Enabled = true;
            mtbRecrutamento.Enabled = true;
            txtID.Enabled = true;
            txtNome.Enabled = true;
            txtTitulo.Enabled = true;
            cmbClasse.Enabled = true;
            txtNacionalidade.Enabled = true;
            btnBrowser.Enabled = true;
            tsbSearch.Text = "";
            txtNome.Focus();
        }

        private void tsbAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != null && txtNome.Text != null && cmbClasse.Text != null && mtbRecrutamento.Text != null && bmp != null && picImagem != null)
            {
                strSql = "UPDATE Agente set Id_agente=@Id_agente, Nome_agente=@Nome_agente, Titulo_agente=@Titulo_agente, Classe=@Classe, Nacionalidade=@Nacionalidade, Imagem=@Imagem, Recrutamento=@Recrutamento WHERE Id_agente=@IdBuscar";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.Add("@IdBuscar", SqlDbType.Int).Value = tstBuscar.Text;
                //comando.Parameters.Add("@NomeBuscar", SqlDbType.VarChar).Value = Int32.Parse(tstBuscar.Text);

                MemoryStream memory = new MemoryStream();

                bmp.Save(memory, ImageFormat.Bmp);

                byte[] foto = memory.ToArray();

                comando.Parameters.Add("Id_agente", SqlDbType.Int).Value = txtID.Text;
                comando.Parameters.Add("Nome_agente", SqlDbType.VarChar).Value = txtNome.Text;
                comando.Parameters.Add("Titulo_agente", SqlDbType.VarChar).Value = txtTitulo.Text;
                comando.Parameters.Add("Classe", SqlDbType.VarChar).Value = cmbClasse.Text;
                comando.Parameters.Add("Nacionalidade", SqlDbType.VarChar).Value = txtNacionalidade.Text;
                comando.Parameters.Add("Recrutamento", SqlDbType.VarChar).Value = mtbRecrutamento.Text;
                comando.Parameters.Add("Imagem", SqlDbType.Binary).Value = foto;


                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Agente atualizado com sucesso.");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    sqlCon.Close();
                }
            }
            else
            {
                lblErro.Text = "Salve uma nova imagem para o Agente!";

            }
            tsbNovo.Enabled = true;
            btnSalvar.Enabled = false;
            tsbAlterar.Enabled = false;
            tsbExcluir.Enabled = false;
            tsbCancelar.Enabled = false;
            tstBuscar.Enabled = true;
            tsbSearch.Enabled = true;
            txtID.Enabled = false;
            txtNome.Enabled = false;
            txtTitulo.Enabled = false;
            cmbClasse.Enabled = false;
            txtNacionalidade.Enabled = false;
            btnBrowser.Enabled = false;
            txtID.Clear();
            txtNome.Clear();
            txtTitulo.Clear();
            tstBuscar.Clear();
            cmbClasse.Text = "";
            tsbSearch.Text = "";
            txtNacionalidade.Clear();
            mtbRecrutamento.Clear();
            picImagem.Image = null;
            mtbRecrutamento.Enabled = false;


        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente expulsar esse Agente?", "Expulsar Agente", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada.");
            }
            else {
                strSql = "DELETE FROM Agente WHERE Id_agente=@Id_agente";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.Add("@Id_agente", SqlDbType.Int).Value = tstBuscar.Text;

                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Agente expulso com sucesso.");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    sqlCon.Close();
                }

                tsbNovo.Enabled = true;
                btnSalvar.Enabled = false;
                tsbAlterar.Enabled = false;
                tsbCancelar.Enabled = false;
                tsbExcluir.Enabled = false;
                tstBuscar.Enabled = true;
                tsbSearch.Enabled = true;
                txtID.Enabled = false;
                txtNome.Enabled = false;
                txtTitulo.Enabled = false;
                btnBrowser.Enabled = false;
                cmbClasse.Enabled = false;
                txtNacionalidade.Enabled = false;
                mtbRecrutamento.Enabled = false;
                txtID.Clear();
                tstBuscar.Text = "";
                txtNome.Clear();
                txtTitulo.Clear();
                cmbClasse.Text = "";
                txtNacionalidade.Clear();
                mtbRecrutamento.Clear();
                picImagem.Image = null;
            }
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            tsbNovo.Enabled = false;
            btnSalvar.Enabled = true;
            tsbAlterar.Enabled = false;
            tsbExcluir.Enabled = false;
            tsbCancelar.Enabled = true;
            tstBuscar.Enabled = false;
            tsbSearch.Enabled = false;
            txtID.Enabled = true;
            txtNome.Enabled = true;
            txtTitulo.Enabled = true;
            cmbClasse.Enabled = true;
            txtNacionalidade.Enabled = true;
            btnBrowser.Enabled = true;
            mtbRecrutamento.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            tsbNovo.Enabled = true;
            btnSalvar.Enabled = false;
            tsbAlterar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbExcluir.Enabled = false;
            tstBuscar.Enabled = true;
            tsbSearch.Enabled = true;
            txtID.Enabled = false;
            txtNome.Enabled = false;
            txtTitulo.Enabled = false;
            cmbClasse.Enabled = false;
            txtNacionalidade.Enabled = false;
            btnBrowser.Enabled = false;
            picImagem.Enabled = false;
            mtbRecrutamento.Enabled = false;
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            tsbNovo.Enabled = true;
            btnSalvar.Enabled = false;
            tsbAlterar.Enabled = false;
            tsbExcluir.Enabled = false;
            tsbCancelar.Enabled = false;
            tstBuscar.Enabled = true;
            tsbSearch.Enabled = true;
            txtID.Enabled = false;
            txtNome.Enabled = false;
            txtTitulo.Enabled = false;
            cmbClasse.Enabled = false;
            mtbRecrutamento.Enabled = false;
            tstBuscar.Text = "";
            txtNacionalidade.Enabled = false;
            txtID.Clear();
            txtNome.Clear();
            txtTitulo.Clear();
            cmbClasse.Text = "";
            lblErro.Text = "";
            txtNacionalidade.Clear();
            btnBrowser.Enabled = false;
            picImagem.Image = null;
            mtbRecrutamento.Clear();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
           
            if (ofdImagem.ShowDialog() == DialogResult.OK) {
                string nome = ofdImagem.FileName;
                bmp = new Bitmap(nome);
                picImagem.Image = bmp;
            }
        }
    }
}