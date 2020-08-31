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
        private bool _dismissDate;
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
            cbxTitleName.DataSource = _titleManager.GetAll();
            cbxTitleName.DisplayMember = "Name";
            cbxTitleName.ValueMember = "Code";

            cbxTitleNameUpdate.DataSource = _titleManager.GetAll();
            cbxTitleNameUpdate.DisplayMember = "Name";
            cbxTitleNameUpdate.ValueMember = "Code";

            //foreach (var title in titleList)
            //    {
            //    using (ComboBoxItem comboBoxItem = new ComboBoxItem())
            //    {
            //        comboBoxItem.Text = title.Name;
            //        comboBoxItem.Value = title.Code;
            //        cbxTitleName.Items.Add(comboBoxItem);
            //    }
            //}
        }
        private void LoadDgwList()
        {
            var workerList = _workerManager.GetAll();
            dgwList.DataSource = workerList;
        }


        private void LoadDepartmants()
        {
            cbxDepartmantName.DataSource = _departmantsManager.GetAll(); ;
            cbxDepartmantName.DisplayMember = "Name";
            cbxDepartmantName.ValueMember = "Code";

            cbxDepartmantUpdate.DataSource = _departmantsManager.GetAll(); ;
            cbxDepartmantUpdate.DisplayMember = "Name";
            cbxDepartmantUpdate.ValueMember = "Code";

            //foreach (var departmant in departmantList)
            //    {
            //    using (ComboBoxItem comboBoxItem = new ComboBoxItem())
            //    {
            //        comboBoxItem.Text = departmant.Name;
            //        comboBoxItem.Value = departmant.Code;
            //        cbxDepartmantName.Items.Add(comboBoxItem);
            //        cbxDepartmantUpdate.Items.Add(comboBoxItem);
            //    }
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool result;
            using (Worker worker = new Worker())
            {
                worker.Name = tbxName.Text;
                worker.Surname = tbxSurname.Text;
                worker.StartDateOfWork = Convert.ToDateTime(dtpStartDateOfWork.Text);
                worker.DismissalDate = new DateTime();
                //worker.DepartmantCode = Convert.ToInt16(((FormUI.OperationsUI.ComboBoxItem)cbxDepartmantName.SelectedItem).Value);
                //worker.DepartmantName = ((FormUI.OperationsUI.ComboBoxItem)cbxDepartmantName.SelectedItem).Text;
                worker.DepartmantCode = Convert.ToInt16(cbxDepartmantName.SelectedValue);
                worker.DepartmantName = cbxDepartmantName.Text;
                worker.Gender = cbxGender.SelectedItem.ToString();
                worker.MobilePhoneNumber = tbxMobilePhoneNumer.Text;
                worker.HomePhoneNumber = tbxMobileHomeNumer.Text;
                //worker.TitleCode = Convert.ToInt16(((FormUI.OperationsUI.ComboBoxItem)cbxTitleName.SelectedItem).Value);
                //worker.TitleName = ((FormUI.OperationsUI.ComboBoxItem)cbxTitleName.SelectedItem).Text;
                worker.TitleCode = Convert.ToInt16(cbxTitleName.SelectedValue);
                worker.TitleName = cbxTitleName.Text;
                worker.EmailAdress = tbxEmail.Text;

                try
                {
                    result = _workerManager.Add(worker);
                    if (result)
                    {
                        MessageBox.Show("Record Added");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Record Not Added: "+ex.Message);
                }
             
            }

          
                LoadDgwList();
        }
  


   

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool result = false;


            if (cbxGenderUpdate.SelectedItem == null)
            {
                MessageBox.Show("Please Choose a Gender");
               
            }
            else
            {
                  using (Worker worker = new Worker())
                {
                    worker.RecordNumber = Convert.ToInt32(dgwList.CurrentRow.Cells[0].Value);
                    worker.Name = tbxNameUpdate.Text;
                    worker.Surname = tbxSurnameUpdate.Text;
                    worker.StartDateOfWork = Convert.ToDateTime(dtpStartDateOfWorkUpdate.Text);
                    if (_dismissDate)
                    {
                        worker.DismissalDate = Convert.ToDateTime(dtpDismissDateUpdate.Text);
                    }
                    //worker.DepartmantCode = Convert.ToInt16(((FormUI.OperationsUI.ComboBoxItem)cbxDepartmantUpdate.SelectedItem).Value);
                    //worker.DepartmantName = ((FormUI.OperationsUI.ComboBoxItem)cbxDepartmantName.SelectedItem).Text;
                    worker.DepartmantCode = Convert.ToInt16(cbxDepartmantUpdate.SelectedValue);
                    worker.DepartmantName = cbxDepartmantUpdate.Text;
                    worker.Gender = cbxGenderUpdate.SelectedItem.ToString();
                    worker.MobilePhoneNumber = tbxMobilePhoneNumberUpdate.Text;
                    worker.HomePhoneNumber = tbxMobilePhoneNumberUpdate.Text;
                    //worker.TitleCode = Convert.ToInt16(((FormUI.OperationsUI.ComboBoxItem)cbxTitleName.SelectedItem).Value);
                    //worker.TitleName = ((FormUI.OperationsUI.ComboBoxItem)cbxTitleName.SelectedItem).Text;
                    worker.TitleCode = Convert.ToInt16(cbxTitleNameUpdate.SelectedValue);
                    worker.TitleName = cbxTitleNameUpdate.Text;
                    worker.EmailAdress = tbxEmailAdressUpdate.Text;
                    try
                    {
                        result = _workerManager.Update(worker);
                        if (result) { MessageBox.Show("Record Updated! " ); }   

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Record Not Updated: "+ex.Message);
                    }
                
                }
            }
            LoadDgwList();
        }


        private void dgwList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwList.CurrentRow;
            tbxNameUpdate.Text = row.Cells[1].Value.ToString();
            tbxSurnameUpdate.Text = row.Cells[2].Value.ToString();
            dtpStartDateOfWorkUpdate.Text = row.Cells[3].Value.ToString();
            cbxDepartmantUpdate.SelectedValue = Convert.ToInt32(row.Cells[5].Value);
            cbxGenderUpdate.SelectedValue = row.Cells[7].Value;
            tbxMobilePhoneNumberUpdate.Text = row.Cells[8].Value.ToString();
            tbxHomePhoneNumberUpdate.Text = row.Cells[9].Value.ToString();

            cbxTitleNameUpdate.SelectedValue = Convert.ToInt32(row.Cells[10].Value);
            tbxEmailAdressUpdate.Text = row.Cells[12].Value.ToString();


            //worker.StartDateOfWork = Convert.ToDateTime(dtpStartDateOfWork.Text);
            //worker.DismissalDate = new DateTime();
            //worker.DepartmantCode = Convert.ToInt16(((FormUI.OperationsUI.ComboBoxItem)cbxDepartmantName.SelectedItem).Value);
            //worker.DepartmantName = ((FormUI.OperationsUI.ComboBoxItem)cbxDepartmantName.SelectedItem).Text;
            //worker.Gender = cbxGender.SelectedItem.ToString();
            //worker.MobilePhoneNumber = tbxMobilePhoneNumer.Text;
            //worker.HomePhoneNumber = tbxMobileHomeNumer.Text;
            //worker.TitleCode = Convert.ToInt16(((FormUI.OperationsUI.ComboBoxItem)cbxTitleName.SelectedItem).Value);
            //worker.TitleName = ((FormUI.OperationsUI.ComboBoxItem)cbxTitleName.SelectedItem).Text;
            //worker.EmailAdress = tbxEmail.Text;

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

        private void dtpDismissDateUpdate_ValueChanged(object sender, EventArgs e)
        {
            _dismissDate = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwList.CurrentRow != null)
            {
                try
                {
                    _workerManager.Delete(new Worker
                    {
                        RecordNumber = Convert.ToInt32(dgwList.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Record Deleted");
                    LoadDgwList();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
        }
    }


}

