﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace ERP.Client.CustomControls.Views
{
    
    public partial class ProjectOverview : UserControl
    {
        public ProjectOverview()
        {
            InitializeComponent();           
        }

        string con = "Server=localhost;Database=SCUDProjectManagementSystem;user id=sa;pwd=123456";  //这里是保存连接数据库的字符串
        string current_row_id_str; //当前行的id值的string值
        string current_table; // 当前表
        string sql;
        string Word = ""; 
        int current_row_index; //当前行
        string current_column_headText = ""; //当前列表头
        bool contextChanged = false; //内容是否发生改变
        bool rowLeave = false;
        bool userAddedRow = false;
        private void ProjectOverview_Load(object sender, EventArgs e)
        {

        }

        private void SelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            if (selectBox.Text.Equals("项目"))         
                sql = "select * from 项目"; 
            else if(selectBox.Text.Equals("客户"))
                sql = "select * from 客户";
            else if(selectBox.Text.Equals("项目成员"))
                sql = "select * from 项目成员";
            else if(selectBox.Text.Equals("员工信息"))
                sql = "select * from 员工信息";
            else if (selectBox.Text.Equals("重大变更履历"))
                sql = "select * from 重大变更履历";

            SqlConnection mycon = new SqlConnection(con);                        //创建SQL连接对象
            current_table = selectBox.Text;
            mycon.Open();                                                        //打开
            SqlDataAdapter myda = new SqlDataAdapter(sql, con);                  //实例化SqlDtatAdapter并执行SQL语句，至于什么是SQLDataAdapter，
                                                                                 //就是用来连接DataSet与数据库的，DataSet是C#中用来保存数据库数据的，
                                                                                 //在这里没有用DataSet，不过原理是一样的，SQLDataAdapter从数据库中取得数据
                                                                                 //然后再DataSet中创建列与行来填充，个人理解。
            DataTable dt = new DataTable();                                     //创建DtatTable实例
            myda.Fill(dt);                                                      //填充table
            dataGridView.DataSource = dt.DefaultView;
        }
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

   
        private void DataGridView_CellLeave(object sender, DataGridViewCellEventArgs e)//离开当前单元格时
        {

        }

        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e) //单元格的值发生更改时
        {
            contextChanged = true;
            if (current_row_id_str != "")
            { 
                Word = dataGridView.CurrentCell.Value.ToString();
                sql = "UPDATE " + current_table + " SET " + current_column_headText + " = "
                      + "\'" + Word + "\'" + " WHERE " + " id = " + current_row_id_str;
                textBox2.Text = "UPDATE " + current_table + " SET " + current_column_headText + " = "
                      + "\'" + Word + "\'" + " WHERE " + " id = " + current_row_id_str;

                SqlConnection mycon = new SqlConnection(con);                        //创建SQL连接对象
                mycon.Open();                                                        //打开
                try                                                                //注意写在try-catch语句，要不然估计没法运行=_=  
                {
                    SqlCommand sqlman = new SqlCommand(sql, mycon);                 //这里的SqlCommand表示要进行一次数据库的操作  
                    if (sqlman.ExecuteNonQuery() != 0)                              //执行数据库语句并返回一个int值（受影响的行数）  
                    {
                        MessageBox.Show("修改数据成功！");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("修改数据失败！");
                }
                Word = "";
                current_column_headText = "";
                contextChanged = false;
            }
            
        }

        private void DataGridView_CellEnter(object sender, DataGridViewCellEventArgs e) //进入当前行时触发
        {
            current_row_index = this.dataGridView.CurrentRow.Index;
            current_row_id_str = this.dataGridView.Rows[current_row_index].Cells[0].Value.ToString(); //获取当前的id
            if (current_row_id_str != "")
            {
                current_column_headText = this.dataGridView.Columns[e.ColumnIndex].HeaderText; //获取当前列的表头  
            }
        }
        private void DataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            /* 由于rowLeave事件先于CellEditEnd调用
             * 此时最后一个cell的修改内容并未被提交（datagridview.cell.value == "")
             * 如果在这里执行数据库操作，最后一个被编辑的cell的内容就无法提交到数据库
             * 但是触发数据库INSERT的逻辑是“界面新增一行，完成内容录入，并将焦点离开本行”
             * 所以需要在这里记录rowLeave事件发生标志，并在CellEditEnd中实际执行数据库操作
             * 特别地，由于离开任意行都会触发本事件，所以本事件被触发时，要识别是离开“上一行”，还是离开“新增行”，处理方法见UserAddedRow事件
             */
            rowLeave = true;
        }
        private void DataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            /* 事件发生顺序：
             * 先RowLeave，再UserAddedRow，最后CellEndEdit
             * 所以这里RowLeave已经true，但表示的是“离开上一行”
             * 所以这里需要把RowLeave清掉，防止在刚进入新行时就触发INSERT操作
             */
            rowLeave = false;
            userAddedRow = true;
        }
        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            /* 处理行新增事件
             * 行新增事件的条件：
             * 1. 刚发生userAddedRow事件
             * 2. Cell内容改变
             * 3. 焦点离开正在编辑的行（表示该行所有cells都完成了编辑）
             */

            if (!rowLeave)
                return;

            if (!userAddedRow)
                return;

            rowLeave = false;
            userAddedRow = false;

            if (current_row_id_str == "")
            {
                if (dataGridView.Columns.Count > 0)
                {
                    current_column_headText = "";
                    for (int i = 1; i < dataGridView.Columns.Count; i++) // 当前表的表头,数据
                    {
                        current_column_headText += dataGridView.Columns[i].HeaderText;
                        Word += "\'" + dataGridView.Rows[current_row_index].Cells[i].Value.ToString() + "\'";
                        if (i < dataGridView.Columns.Count - 1)
                        {
                            current_column_headText += ",";
                            Word += ",";
                        }

                    }

                    sql = "INSERT INTO " + current_table + "(" + current_column_headText + ")" + " VALUES(" + Word + ")";
                    textBox2.Text = sql;
                    SqlConnection mycon = new SqlConnection(con);                        //创建SQL连接对象
                    mycon.Open();                                                        //打开
                    try                                                                //注意写在try-catch语句，要不然估计没法运行 
                    {
                        SqlCommand sqlman = new SqlCommand(sql, mycon);                 //这里的SqlCommand表示要进行一次数据库的操作  
                        if (sqlman.ExecuteNonQuery() != 0)                              //执行数据库语句并返回一个int值（受影响的行数）  
                        {
                            MessageBox.Show("数据创建成功！");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("修改数据失败！");
                    }

                    refresh();
                    Word = "";
                    current_column_headText = "";
                    contextChanged = false;
                }

            }
        }



    }
}
