using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.ORMs.EntityFramework.DataAccessLayers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class OperationsUI : Form
    {

        IProductService _productManager;
        public OperationsUI()
        {
            InitializeComponent();
            _productManager=  new ProductManager();
        }

        private void OperationsUI_Load(object sender, EventArgs e)
        {
            LoadDgwList();

        }

        private void LoadDgwList()
        {
            var productList = _productManager.GetAll();
            dgwList.DataSource = productList;
        }

    }
}
