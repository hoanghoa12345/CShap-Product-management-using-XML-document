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
using System.Xml;

namespace baitap5_xml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private PictureBox picture = new PictureBox();
        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaTextBox();
        }

        private void XoaTextBox()
        {
            txtTenSp.ResetText();
            txtLinkFile.ResetText();
            cbxTheloai.ResetText();
            txtMaSP.ResetText();
            ptbHinhAnh.Image = null;
            ActiveControl = txtTenSp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxTheloai.Text = "--Chọn một--";
            cbxTheloai.Items.Add("Điện tử");
            cbxTheloai.Items.Add("Tv/Điện gia dụng");
            cbxTheloai.Items.Add("Thời trang");
            cbxTheloai.Items.Add("Tiện ích");
            cbxTheloai.Items.Add("Phụ kiện công nghệ");
            cbxTheloai.Items.Add("Bách hoá");

            LoadXmlDoc();
        }
        private string path = "dssanpham.xml";
        private void LoadXmlDoc()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlNode rootNode;
            XmlNode sanphamNode;
            DataTable table1 = new DataTable("sanphamtb");
            table1.Columns.Add("masp");
            table1.Columns.Add("tensanpham");
            table1.Columns.Add("theloai");
            table1.Columns.Add("hinhanh");
            table1.Columns.Add("image", typeof(Image));
            rootNode = xmlDoc.DocumentElement;
            sanphamNode = rootNode.SelectSingleNode("//sanpham");
            XmlNodeList searchNodes = sanphamNode.ChildNodes;
            
            foreach (XmlNode searchNode in searchNodes)
            {
                table1.Rows.Add(searchNode.Attributes["masp"].Value,
                                searchNode.Attributes["ten"].Value,
                                searchNode.Attributes["theloai"].Value,
                                searchNode.Attributes["hinhanh"].Value,
                                picture.Image = new Bitmap(@searchNode.Attributes["hinhanh"].Value));
            }
            DataSet set = new DataSet("product");
            set.Tables.Add(table1);
            dataGridView.RowTemplate.Height = 64;
            dataGridView.DataSource = set.Tables[0];
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn tệp hình ảnh...";
            openFileDialog.Filter = "image files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtLinkFile.Text = openFileDialog.FileName.ToString();
                ptbHinhAnh.Image = new Bitmap(openFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlNode rootNode, spNode, itemSpNode;
            XmlAttribute attribute;
            if (xmlDoc != null)
            { 
                rootNode = xmlDoc.DocumentElement;

                spNode = rootNode.SelectSingleNode("sanpham");
                itemSpNode = xmlDoc.CreateElement("itemSanpham");

                attribute = xmlDoc.CreateAttribute("masp");
                attribute.Value = txtMaSP.Text;
                itemSpNode.Attributes.Append(attribute);

                attribute = xmlDoc.CreateAttribute("ten");
                attribute.Value = txtTenSp.Text;
                itemSpNode.Attributes.Append(attribute);

                attribute = xmlDoc.CreateAttribute("theloai");
                attribute.Value = cbxTheloai.Text;
                itemSpNode.Attributes.Append(attribute);

                attribute = xmlDoc.CreateAttribute("hinhanh");
                attribute.Value = txtLinkFile.Text;
                itemSpNode.Attributes.Append(attribute);

                spNode.AppendChild(itemSpNode);

                //Luu file 
                xmlDoc.Save(path);

                XoaTextBox();
                LoadXmlDoc();
            }
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtTenSp.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnXoaSp_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlNode rootNode;
            XmlNode spNode, itemSpNode;
            var confirmResult = MessageBox.Show("Bạn muốn xoá sản phẩm này ?",
                                     "Xoá Sản phẩm!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (xmlDoc != null)
                {
                    rootNode = xmlDoc.DocumentElement;
                    spNode = rootNode.SelectSingleNode("//sanpham");
                    itemSpNode = spNode.SelectSingleNode("//itemSanpham[@ten = '" + txtTenSp.Text + "']");
                    if (itemSpNode != null)
                    {
                        XoaTextBox();
                    }

                    spNode.RemoveChild(itemSpNode);

                    DataTable table1 = new DataTable("sanphamtb");
                    table1.Columns.Add("masp");
                    table1.Columns.Add("tensanpham");
                    table1.Columns.Add("theloai");
                    table1.Columns.Add("hinhanh");

                    XmlNodeList searchNodes = spNode.SelectNodes("//itemSanpham[contains(@ten , '" + txtTenSp.Text + "')]");
                    foreach (XmlNode searchNode in searchNodes)
                    {
                        table1.Rows.Add(searchNode.Attributes["masp"].Value, searchNode.Attributes["ten"].Value, searchNode.Attributes["theloai"].Value, searchNode.Attributes["hinhanh"].Value);
                    }
                    DataSet set = new DataSet("product");
                    set.Tables.Add(table1);
                    dataGridView.DataSource = set.Tables[0];

                    xmlDoc.Save(path);
                }
            }
        }

        private void txtTenSp_TextChanged(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlNode rootNode;
            XmlNode spNode, itemSpNode;
            if (xmlDoc != null)
            {
                rootNode = xmlDoc.DocumentElement;
                spNode = rootNode.SelectSingleNode("//sanpham");
                itemSpNode = spNode.SelectSingleNode("//itemSanpham[@ten = '" + txtTenSp.Text + "']");
                if (itemSpNode != null)
                {
                    txtTenSp.Text = itemSpNode.Attributes["ten"].Value.ToString();
                    cbxTheloai.Text = itemSpNode.Attributes["theloai"].Value.ToString();
                    txtLinkFile.Text = itemSpNode.Attributes["hinhanh"].Value.ToString();
                    txtMaSP.Text = itemSpNode.Attributes["masp"].Value.ToString();
                    ptbHinhAnh.Image = new Bitmap(itemSpNode.Attributes["hinhanh"].Value);

                }
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            LoadXmlDoc();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlNode rootNode;
            XmlNode spNode, itemSpNode;
            if (xmlDoc != null)
            {
                rootNode = xmlDoc.DocumentElement;
                spNode = rootNode.SelectSingleNode("//sanpham");
                itemSpNode = spNode.SelectSingleNode("//itemSanpham[@ten = '" + txtTenSp.Text + "']");
                if (itemSpNode != null)
                {
                    txtTenSp.Text = itemSpNode.Attributes["ten"].Value.ToString();
                    cbxTheloai.Text = itemSpNode.Attributes["theloai"].Value.ToString();
                    txtLinkFile.Text = itemSpNode.Attributes["hinhanh"].Value.ToString();
                    txtMaSP.Text = itemSpNode.Attributes["masp"].Value.ToString();
                    try
                    {
                        if (txtLinkFile.Text != null)
                        {
                            ptbHinhAnh.Image = Image.FromFile(@txtLinkFile.Text);
                            ptbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK);
                    }

                }
                DataTable table1 = new DataTable("sanphamtb");
                table1.Columns.Add("masach");
                table1.Columns.Add("tensanpham");
                table1.Columns.Add("theloai");
                table1.Columns.Add("hinhanh");
                table1.Columns.Add("image", typeof(Image));
                XmlNodeList searchNodes = spNode.SelectNodes("//itemSanpham[contains(@ten , '" + txtTenSp.Text + "')]");
                foreach (XmlNode searchNode in searchNodes)
                {
                    table1.Rows.Add(searchNode.Attributes["masp"].Value, searchNode.Attributes["ten"].Value, searchNode.Attributes["theloai"].Value, searchNode.Attributes["hinhanh"].Value, picture.Image = new Bitmap(@searchNode.Attributes["hinhanh"].Value));
                }
                DataSet set = new DataSet("product");
                set.Tables.Add(table1);
                dataGridView.DataSource = set.Tables[0];
            }
        }
    }
}