using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LibraryDal _libraryDal = new LibraryDal();

        //List
        private void LoadBooks()
        {
            dgwLibrary.DataSource = _libraryDal.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        //Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _libraryDal.Add(new Library
            {
                BookName = tbxNameAdd.Text,
                AuthorName = tbxAuthorNameAdd.Text,
                NumberPages = Convert.ToInt32(tbxNumberPagesAdd.Text),
                PublishingHouse = tbxPublishingHouseAdd.Text
                
            });

            LoadBooks();
            MessageBox.Show("Book Added!");
        }


        //Update
        private void dgwLibrary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwLibrary.CurrentRow.Cells[1].Value.ToString();
            tbxAuthorNameUpdate.Text = dgwLibrary.CurrentRow.Cells[2].Value.ToString();
            tbxNumberPagesUpdate.Text = dgwLibrary.CurrentRow.Cells[3].Value.ToString();
            tbxPublishingHouseUpdate.Text = dgwLibrary.CurrentRow.Cells[4].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _libraryDal.Update(new Library
            {
                BookId = Convert.ToInt32(dgwLibrary.CurrentRow.Cells[0].Value.ToString()),
                BookName = tbxNameUpdate.Text,
                AuthorName = tbxAuthorNameUpdate.Text,
                NumberPages = Convert.ToInt32(tbxNumberPagesUpdate.Text),
                PublishingHouse= tbxPublishingHouseUpdate.Text,


            });

            LoadBooks();
            MessageBox.Show("Book Updated!");
        }


        //Delete
        private void btnRemove_Click(object sender, EventArgs e)
        {
            _libraryDal.Delete(new Library
            {
                BookId = Convert.ToInt32(dgwLibrary.CurrentRow.Cells[0].Value)
            });

            LoadBooks();
            MessageBox.Show("Book Deleted!");
        }


        //Search
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchBooks(tbxSearch.Text);
        }

        private void SearchBooks(string key)
        {
            //dgwProducts.DataSource = _productDal.GetAll().Where(p => p.Name.Contains(key)).ToList(); //küçük harfle yazınca gelmiyor ama büyük harfle yazınca geliyor sebebi koleksiyonlarla yani list ile çalışıyor olmak

            var result = _libraryDal.GetByName(key); //küçük veya büyük harfle yazılması sorun degik çünkü direk veri tabanından alıyoruz veriyi 
            dgwLibrary.DataSource = result;
        }
    }
}
