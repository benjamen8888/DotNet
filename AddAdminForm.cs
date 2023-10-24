using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class AddAdminForm : Form
    {
        public AddAdminForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            /*bool isValid = false;*/
            string memberName = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            string address = addressTextBox.Text;
            string phone = phoneTextBox.Text;
            DateTime birthDate = birthDatePicker.Value;
            // object selectedValue = roleListBox.SelectedItem;
            string selectedUserType;
            // Initialize error messages
            string errorMessage = string.Empty;
            // Check if the username is empty
            if (string.IsNullOrWhiteSpace(memberName))
            {
                errorMessage += "Username cannot be empty.\n";
            }
            // Check if the password is empty
            if (string.IsNullOrWhiteSpace(password))
            {
                errorMessage += "Password cannot be empty.\n";
            }
            // Check if the address is empty
            if (string.IsNullOrWhiteSpace(address))
            {
                errorMessage += "Address cannot be empty.\n";
            }
            // Check if the phone number format is correct
            if (!phone.StartsWith("04") || phone.Length != 10 || !phone.All(char.IsDigit))
            {
                errorMessage += "Invalid phone number format.\n";
            }

            // Check if the birth date is greater than the current date
            if (birthDate > DateTime.Now.Subtract(TimeSpan.FromDays(1)))
            {
                errorMessage += "Birth date cannot be greater than the current date.\n";
            }

            // Check if the userTypeComboBox is empty
            if (!string.IsNullOrEmpty(errorMessage))
            {
                DialogResult result = MessageBox.Show(errorMessage, "Input Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    ClearInvalidInputs(errorMessage);
                }
            }
            else
            {
                string dateOnlyString = birthDate.ToString("yyyy-MM-dd"); // 仅日期部分

                // 密码匹配
                // 创建一个 SQL 查询字符串，将数据插入到数据库中
                string insertQuery =
                    "INSERT INTO members (memberpasswd, memberName, memberAddress, role,phone, birthDate,imagePath,backGround) " +
                    "VALUES ( @memberpasswd, @memberName, @memberAddress, @role, @phone,@birthDate,@imagePath,@backGround)";
                string connectionString =
                    "Server=(localdb)\\mssqllocaldb;Database=AssignmentDB;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // 使用参数化查询以避免 SQL 注入
                        Random random = new Random();
                        int memberId = random.Next(10000, 99999); // 生成一个介于10000和99999之间的随机整数
                        string memberIdString = memberId.ToString("D5"); // 将生成的整数格式化为五位数的字符串

                        // memberIdString 就是随机生成的五位数的 memberId
                        command.Parameters.AddWithValue("@memberName", memberName);
                        command.Parameters.AddWithValue("@memberpasswd", password);
                        command.Parameters.AddWithValue("@memberAddress", address);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@birthDate", birthDate);
                        command.Parameters.AddWithValue("@role", "admin");
                        command.Parameters.AddWithValue("@imagePath", "default.png");
                        command.Parameters.AddWithValue("@backGround", "background.png");
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(@"insert successfully");
                            this.Close();
                        }
                        else
                        {
                            Console.WriteLine("数据插入失败。");
                        }
                    }
                }
            }
        }

        private void ClearInvalidInputs(string errorMessage)
        {
            // 清除错误的字段并将焦点设置回相应的文本框
            if (errorMessage.Contains("用户名不能为空"))
            {
                userNameTextBox.Clear();
                userNameTextBox.Focus();
            }

            if (errorMessage.Contains("密码不能为空"))
            {
                passwordTextBox.Clear();
                passwordTextBox.Focus();
            }

            if (errorMessage.Contains("地址不能为空"))
            {
                addressTextBox.Clear();
                addressTextBox.Focus();
            }

            if (errorMessage.Contains("手机号格式不正确"))
            {
                phoneTextBox.Clear();
                phoneTextBox.Focus();
            }

            if (errorMessage.Contains("出生日期不能大于当前日期"))
            {
                birthDatePicker.Value = DateTime.Now; // 重置日期时间选择器为当前日期
                birthDatePicker.Focus();
            }

            if (errorMessage.Contains("请选择用户类型"))
            {
                // 清除选择并将焦点设置回 userTypeComboBox
                roleListBox.SelectedIndex = -1; // 清除选择
                roleListBox.Focus();
            }
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {
        }
    }
}