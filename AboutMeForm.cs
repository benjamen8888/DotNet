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
    public partial class AboutMeForm : Form
    {
        private string SelectedFilePath { get; set; }
        public AboutMeForm()
        {
            string? memberImagePath = Utility.GetMemberImagePath(LoginForm.GetMemberId());
            InitializeComponent();
            ShowFormMethod(memberImagePath);
        }



        private void LoadImageFromDisk(string fileName)
        {
            string imagePath = Path.Combine(Application.StartupPath, "picture", fileName);
            Console.WriteLine("Application.StartupPath==================");
            Console.WriteLine(Application.StartupPath);
            if (File.Exists(imagePath))
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }
        }

        private void CreateAndStoreImagePath()
        {
            string userFileName = openFileDialog.FileName;
            // 生成时间戳作为文件名
            string timeNow = DateTime.Now.ToString("yyyyMMddHHmmssfff");

            // 构建目标文件的完整路径，包括 picture 文件夹和文件名
            string folderTarget = Path.Combine(Application.StartupPath, "picture");
            string fileName = $"{timeNow}.png"; // 假设保存为 JPG 格式
            string filePath = Path.Combine(folderTarget, fileName);
            Utility.StoreMemberImagePath(LoginForm.GetMemberId(), fileName);
            try
            {
                // 确保目标文件夹存在
                Directory.CreateDirectory(folderTarget);
                // 使用 File.Copy 将文件复制到目标路径
                File.Copy(userFileName, filePath);
                // 更新 PictureBox 显示
                pictureBox.Image = Image.FromFile(filePath);
                // 此时 targetFilePath 可以保存到数据库或其他地方以备后用
            }
            catch (Exception ex)
            {
                MessageBox.Show(@$"Error saving image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowFormMethod(string? memberImagePath)
        {
            SelectedFilePath = memberImagePath ?? "default.png";
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";
            openFileDialog.Title = "Select an Image File";
            LoadImageFromDisk(SelectedFilePath); // Default image file name
            GetAdminInfo();
            // Get today's day
            DateTime today = DateTime.Today;
        }

        private void GetAdminInfo()
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=AssignmentDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "select memberId, role,memberpasswd, memberName, memberAddress, phone, birthDate " +
                             "from members " +
                             "WHERE memberId = @memberId";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue(@"memberId", LoginForm.GetMemberId());

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Check if there are result
                        if (reader.Read())
                        {
                            // Extracts the data and assigns it to the Text property of the Label control
                            SetResultText(reader);
                        }
                        else
                        {
                            // There are no resulting lines, and appropriate processing code can be added
                            // Displays a message box indicating that no data was found
                            MessageBox.Show("Information was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void SetResultText(SqlDataReader reader)
        {
            memberId.Text = reader["memberId"].ToString();
            memberpasswd.Text = reader["memberpasswd"].ToString();
            memberName.Text = reader["memberName"].ToString();
            memberAddress.Text = reader["memberAddress"].ToString();
            phone.Text = reader["phone"].ToString();
            birthDate.Text = reader["birthDate"].ToString();
            role.Text = reader["role"].ToString();
        }

        private void UploadPictureButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Delete previous images (if they exist)
                string existingImagePath = Path.Combine(Application.StartupPath, "picture", "default.png"); // 默认图片文件名
                // Console.WriteLine(existingImagePath + "=========================");
                // Console.WriteLine(existingImagePath);
                CreateAndStoreImagePath();
            }
        }
    }
}