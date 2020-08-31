using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.ORMs.EntityFramework.DataAccessLayers;
using Entities.Concrete;
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
        IWorkerService _workerManager;
        ITitleService _titleManager;
        IDepartmantService _departmantsManager;
        public OperationsUI()
        {
            InitializeComponent();
            //_productManager = new ProductManager();
            _workerManager = new WorkerManager();
            _titleManager = new TitleManager();
            _departmantsManager = new DepartmantManager();
        }

        private void OperationsUI_Load(object sender, EventArgs e)
        {
            LoadDgwList();
            LoadTitles();
            LoadDepartmants();
            tbxName.Text = "Görkem Kaan";
            tbxSurname.Text = "Sevinç";
            tbxMobilePhoneNumer.Text = "5313046388";
            tbxEmail.Text = "gkaansevinc@gmail.com";
            

        }

        private void LoadTitles()
        {
            var titleList = _titleManager.GetAll();
                foreach (var title in titleList)
                {
                using (ComboBoxItem comboBoxItem = new ComboBoxItem())
                {
                    comboBoxItem.Text = title.Name;
                    comboBoxItem.Value = title.Code;
                    cbxTitleName.Items.Add(comboBoxItem);
                }
            }
        }

        private void LoadDepartmants()
        {
           var departmantList = _departmantsManager.GetAll();
                foreach (var departmant in departmantList)
                {
                using (ComboBoxItem comboBoxItem = new ComboBoxItem())
                {
                    comboBoxItem.Text = departmant.Name;
                    comboBoxItem.Value = departmant.Code;
                    cbxDepartmantName.Items.Add(comboBoxItem);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Worker worker = new Worker())
            {
                worker.Name = tbxName.Text;
                worker.Surname = tbxSurname.Text;
                worker.StartDateOfWork = Convert.ToDateTime(dtpStartDateOfWork.Text);
                worker.DismissalDate = new DateTime();
                worker.DepartmantCode = Convert.ToInt16(((FormUI.OperationsUI.ComboBoxItem)cbxDepartmantName.SelectedItem).Value);
                worker.DepartmantName = ((FormUI.OperationsUI.ComboBoxItem)cbxDepartmantName.SelectedItem).Text;
                worker.Gender = cbxGender.SelectedItem.ToString();
                worker.MobilePhoneNumber = tbxMobilePhoneNumer.Text;
                worker.HomePhoneNumber = tbxMobileHomeNumer.Text;
                worker.TitleCode = Convert.ToInt16(((FormUI.OperationsUI.ComboBoxItem)cbxTitleName.SelectedItem).Value);
                worker.TitleName = ((FormUI.OperationsUI.ComboBoxItem)cbxTitleName.SelectedItem).Text;
                worker.EmailAdress = tbxEmail.Text;     
            _workerManager.Add(worker);
            };
            LoadDgwList();
        }
  


    private void LoadDgwList()
    {
        //var productList = _productManager.GetAll();
        //dgwList.DataSource = productList;

        var workerList = _workerManager.GetAll();
        dgwList.DataSource = workerList;
    }





        private class ComboBoxItem : IDisposable
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString()
            {
                return Text;
            }

            #region IDisposable Support
            private bool disposedValue = false; // To detect redundant calls

            protected virtual void Dispose(bool disposing)
            {
                if (!disposedValue)
                {
                    if (disposing)
                    {
                        // TODO: dispose managed state (managed objects).
                    }

                    // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                    // TODO: set large fields to null.

                    disposedValue = true;
                }
            }

            // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
            // ~ComboBoxItem() {
            //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            //   Dispose(false);
            // }

            // This code added to correctly implement the disposable pattern.
            public void Dispose()
            {
                // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
                Dispose(true);
                // TODO: uncomment the following line if the finalizer is overridden above.
                // GC.SuppressFinalize(this);
            }
            #endregion
        }


    }


}

