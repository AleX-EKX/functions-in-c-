using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr
{
    public partial class Form4 : Form
    {
        enum RowState
        {
            Existed,
            New,
            Modified,
            ModifiedNew,
            Deleted
        }
        DB db = new DB();
        int selectedRow;
        
        public Form4()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id поставщика");
            dataGridView1.Columns.Add("name_supplier", "Наименование поставщика");
            dataGridView1.Columns.Add("type_supplier", "Тип поставщика");
            dataGridView1.Columns.Add("inn", "ИНН");
            dataGridView1.Columns.Add("reyting", "Рейтинг");
            dataGridView1.Columns.Add("data_raboti", "Дата начала работы");
            dataGridView1.Columns.Add("IsNew",String.Empty);

        }

        private void ClearFields()
        {
            textBox_id.Text = "";
            textBox_supplier.Text = "";
            textBox_typesup.Text = "";
            textBox_inn.Text = "";
            textBox_reyting.Text = "";
            textBox_datar.Text = "";
        }

        private void ReadSinglRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), 
                record.GetString(4), record.GetString(5), RowState.ModifiedNew);

        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryString = $"select * from supplier";
            MySqlCommand command = new MySqlCommand(queryString, db.GetConnection());
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSinglRow(dgv, reader);
            }
            reader.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_supplier.Text = row.Cells[1].Value.ToString();
                textBox_typesup.Text = row.Cells[2].Value.ToString();
                textBox_inn.Text = row.Cells[3].Value.ToString();
                textBox_reyting.Text = row.Cells[4].Value.ToString();
                textBox_datar.Text = row.Cells[5].Value.ToString();
            }
        }

        

        private void add_btn_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            //addForm.Owner = this;
            addForm.Show();
        }
        //поиск
        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string searchString = $"select * from supplier where concat (id_supplier, name_supplier, type_supplier, inn, reyting, data_raboti) like '%" + textBox_search.Text + "%'";
            MySqlCommand com = new MySqlCommand(searchString, db.GetConnection());
            db.openConnection();
            MySqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSinglRow(dgv, read);
            }
            read.Close();
        }
        //поиск
        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        //удаление
        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty) 
            {
                dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted; 
                return;
            }
            dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
        }

        //редактирование
        private void Update()
        {

            db.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {


                var rowState = (RowState)dataGridView1.Rows[index].Cells[6].Value;
                if (rowState == RowState.Existed)
                  continue;

                if (rowState == RowState.Deleted)
                {

                var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value); 
                var deleteQuery = $"delete from supplier where id_supplier = {id}";
                var command = new MySqlCommand(deleteQuery, db.GetConnection()); 
                command.ExecuteNonQuery(); 
                }
                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].ToString();
                    var supplier  = dataGridView1.Rows[index].Cells[1].ToString();
                    var type = dataGridView1.Rows[index].Cells[2].ToString();
                    var inn = dataGridView1.Rows[index].Cells[3].ToString();
                    var reyting = dataGridView1.Rows[index].Cells[4].ToString();
                    var datar = dataGridView1.Rows[index].Cells[5].ToString();
                    var changeQuery = $"update supplier set name_supplier = '{supplier}', type_supplier = '{type}',inn = '{inn}',reyting = '{reyting}',data_raboti = '{datar}' where id_supplier = '{id}'";
                    var command = new MySqlCommand(changeQuery, db.GetConnection());
                    command.ExecuteNonQuery();
                }
            }
            db.closeConnection();
        }
        //обновление
        private void update_btn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        //удаление
        private void del_btn_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }
        //сохранение
        private void save_btn_Click(object sender, EventArgs e)
        {
            Update();
        }
        //редактирование
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var id = textBox_id.Text;
            var supplier = textBox_supplier.Text;
            var type = textBox_typesup.Text;
            int inn;
            var reyting = textBox_reyting.Text;

            var datar = textBox_datar.Text;
            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {


                if (int.TryParse(textBox_inn.Text, out inn))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, supplier, type, inn, reyting, datar);
                    dataGridView1.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Цена должна иметь числовой форматі", "Ошибка!");

                }
            }
            
        }

        private void izm_btn_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
