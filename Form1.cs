using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using MicrofinanceApp.Services;

namespace MicrofinanceApp
{
    public partial class Form1 : Form
    {
        private readonly CrudService service = new CrudService();

        private int? selectedClientId;
        private int? selectedManagerId;
        private int? selectedLoanId;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigureGrids();
            LoadClients();
            LoadManagers();
            LoadLoanCombos();
            LoadLoans();
        }

        private void ConfigureGrids()
        {
            dgvClients.AutoGenerateColumns = true;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClients.MultiSelect = false;
            dgvClients.ReadOnly = true;
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;

            dgvManagers.AutoGenerateColumns = true;
            dgvManagers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvManagers.MultiSelect = false;
            dgvManagers.ReadOnly = true;
            dgvManagers.AllowUserToAddRows = false;
            dgvManagers.AllowUserToDeleteRows = false;

            dgvLoans.AutoGenerateColumns = true;
            dgvLoans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoans.MultiSelect = false;
            dgvLoans.ReadOnly = true;
            dgvLoans.AllowUserToAddRows = false;
            dgvLoans.AllowUserToDeleteRows = false;

            dgvClients.CellClick += dgvClients_CellClick;
            dgvManagers.CellClick += dgvManagers_CellClick;
            dgvLoans.CellClick += dgvLoans_CellClick;
        }

        private void LoadClients()
        {
            try
            {
                dgvClients.DataSource = null;
                dgvClients.DataSource = service.GetClients();

                if (dgvClients.Columns["Id"] != null)
                    dgvClients.Columns["Id"].Visible = false;

                if (dgvClients.Columns["FullName"] != null)
                    dgvClients.Columns["FullName"].HeaderText = "ФИО клиента";

                if (dgvClients.Columns["Phone"] != null)
                    dgvClients.Columns["Phone"].HeaderText = "Телефон";

                selectedClientId = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки клиентов:\n" + ex.Message);
            }
        }

        private void LoadManagers()
        {
            try
            {
                dgvManagers.DataSource = null;
                dgvManagers.DataSource = service.GetManagers();

                if (dgvManagers.Columns["Id"] != null)
                    dgvManagers.Columns["Id"].Visible = false;

                if (dgvManagers.Columns["FullName"] != null)
                    dgvManagers.Columns["FullName"].HeaderText = "ФИО менеджера";

                if (dgvManagers.Columns["Department"] != null)
                    dgvManagers.Columns["Department"].HeaderText = "Отдел";

                selectedManagerId = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки менеджеров:\n" + ex.Message);
            }
        }

        private void LoadLoanCombos()
        {
            try
            {
                cmbLoanClient.DataSource = null;
                cmbLoanClient.DisplayMember = "FullName";
                cmbLoanClient.ValueMember = "Id";
                cmbLoanClient.DataSource = service.GetClients();

                cmbLoanManager.DataSource = null;
                cmbLoanManager.DisplayMember = "FullName";
                cmbLoanManager.ValueMember = "Id";
                cmbLoanManager.DataSource = service.GetManagers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки списков для займов:\n" + ex.Message);
            }
        }

        private void LoadLoans()
        {
            try
            {
                using (var db = new Data.AppDbContext())
                {
                    var loans = db.Loans
                        .Include(x => x.Client)
                        .Include(x => x.Manager)
                        .OrderByDescending(x => x.Id)
                        .Select(x => new
                        {
                            x.Id,
                            ClientId = x.ClientId,
                            ManagerId = x.ManagerId,
                            Клиент = x.Client.FullName,
                            Телефон = x.Client.Phone,
                            Менеджер = x.Manager.FullName,
                            x.Amount,
                            x.InterestRate,
                            x.IssueDate,
                            x.DueDate,
                            x.Comment,
                            ИтоговаяСумма = x.Amount + (x.Amount * x.InterestRate / 100m)
                        })
                        .ToList();

                    dgvLoans.DataSource = null;
                    dgvLoans.DataSource = loans;

                    if (dgvLoans.Columns["Id"] != null)
                        dgvLoans.Columns["Id"].Visible = false;

                    if (dgvLoans.Columns["ClientId"] != null)
                        dgvLoans.Columns["ClientId"].Visible = false;

                    if (dgvLoans.Columns["ManagerId"] != null)
                        dgvLoans.Columns["ManagerId"].Visible = false;

                    if (dgvLoans.Columns["Клиент"] != null)
                        dgvLoans.Columns["Клиент"].HeaderText = "ФИО клиента";

                    if (dgvLoans.Columns["Телефон"] != null)
                        dgvLoans.Columns["Телефон"].HeaderText = "Телефон";

                    if (dgvLoans.Columns["Менеджер"] != null)
                        dgvLoans.Columns["Менеджер"].HeaderText = "Менеджер";

                    if (dgvLoans.Columns["Amount"] != null)
                        dgvLoans.Columns["Amount"].HeaderText = "Сумма";

                    if (dgvLoans.Columns["InterestRate"] != null)
                        dgvLoans.Columns["InterestRate"].HeaderText = "Процент";

                    if (dgvLoans.Columns["IssueDate"] != null)
                        dgvLoans.Columns["IssueDate"].HeaderText = "Дата выдачи";

                    if (dgvLoans.Columns["DueDate"] != null)
                        dgvLoans.Columns["DueDate"].HeaderText = "Дата погашения";

                    if (dgvLoans.Columns["Comment"] != null)
                        dgvLoans.Columns["Comment"].HeaderText = "Комментарий";

                    if (dgvLoans.Columns["ИтоговаяСумма"] != null)
                        dgvLoans.Columns["ИтоговаяСумма"].HeaderText = "Итоговая сумма";
                }

                selectedLoanId = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки займов:\n" + ex.Message);
            }
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvClients.Rows[e.RowIndex];
            selectedClientId = Convert.ToInt32(row.Cells["Id"].Value);
            txtClientFullName.Text = row.Cells["FullName"].Value?.ToString();
            txtClientPhone.Text = row.Cells["Phone"].Value?.ToString();
        }

        private void dgvManagers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvManagers.Rows[e.RowIndex];
            selectedManagerId = Convert.ToInt32(row.Cells["Id"].Value);
            txtManagerFullName.Text = row.Cells["FullName"].Value?.ToString();
            txtDepartment.Text = row.Cells["Department"].Value?.ToString();
        }

        private void dgvLoans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvLoans.Rows[e.RowIndex];
            selectedLoanId = Convert.ToInt32(row.Cells["Id"].Value);

            txtLoanAmount.Text = row.Cells["Amount"].Value?.ToString();
            txtInterestRate.Text = row.Cells["InterestRate"].Value?.ToString();
            dtpIssueDate.Value = Convert.ToDateTime(row.Cells["IssueDate"].Value);
            dtpDueDate.Value = Convert.ToDateTime(row.Cells["DueDate"].Value);
            txtComment.Text = row.Cells["Comment"].Value?.ToString();

            if (row.Cells["ClientId"].Value != null)
                cmbLoanClient.SelectedValue = Convert.ToInt32(row.Cells["ClientId"].Value);

            if (row.Cells["ManagerId"].Value != null)
                cmbLoanManager.SelectedValue = Convert.ToInt32(row.Cells["ManagerId"].Value);
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                service.AddClient(txtClientFullName.Text, txtClientPhone.Text);
                LoadClients();
                LoadLoanCombos();
                MessageBox.Show("Клиент добавлен.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedClientId == null)
                {
                    MessageBox.Show("Выберите клиента.");
                    return;
                }

                service.UpdateClient(selectedClientId.Value, txtClientFullName.Text, txtClientPhone.Text);
                LoadClients();
                LoadLoanCombos();
                MessageBox.Show("Клиент изменен.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedClientId == null)
                {
                    MessageBox.Show("Выберите клиента.");
                    return;
                }

                service.DeleteClient(selectedClientId.Value);
                LoadClients();
                LoadLoanCombos();
                LoadLoans();
                ClearClientFields();
                MessageBox.Show("Клиент удален.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshClients_Click(object sender, EventArgs e)
        {
            LoadClients();
            LoadLoanCombos();
        }

        private void btnAddManager_Click(object sender, EventArgs e)
        {
            try
            {
                service.AddManager(txtManagerFullName.Text, txtDepartment.Text);
                LoadManagers();
                LoadLoanCombos();
                MessageBox.Show("Менеджер добавлен.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateManager_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedManagerId == null)
                {
                    MessageBox.Show("Выберите менеджера.");
                    return;
                }

                service.UpdateManager(selectedManagerId.Value, txtManagerFullName.Text, txtDepartment.Text);
                LoadManagers();
                LoadLoanCombos();
                MessageBox.Show("Менеджер изменен.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteManager_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedManagerId == null)
                {
                    MessageBox.Show("Выберите менеджера.");
                    return;
                }

                service.DeleteManager(selectedManagerId.Value);
                LoadManagers();
                LoadLoanCombos();
                LoadLoans();
                ClearManagerFields();
                MessageBox.Show("Менеджер удален.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshManagers_Click(object sender, EventArgs e)
        {
            LoadManagers();
            LoadLoanCombos();
        }

        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtLoanAmount.Text, out decimal amount))
                {
                    MessageBox.Show("Сумма кредита должна быть числом.");
                    return;
                }

                if (!decimal.TryParse(txtInterestRate.Text, out decimal rate))
                {
                    MessageBox.Show("Процент должен быть числом.");
                    return;
                }

                if (cmbLoanClient.SelectedValue == null)
                {
                    MessageBox.Show("Выберите клиента.");
                    return;
                }

                if (cmbLoanManager.SelectedValue == null)
                {
                    MessageBox.Show("Выберите менеджера.");
                    return;
                }

                service.AddLoan(
                    Convert.ToInt32(cmbLoanClient.SelectedValue),
                    amount,
                    rate,
                    dtpIssueDate.Value,
                    dtpDueDate.Value,
                    txtComment.Text,
                    Convert.ToInt32(cmbLoanManager.SelectedValue));


                LoadLoans();
                ClearLoanFields();
                MessageBox.Show("Заем добавлен.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateLoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedLoanId == null)
                {
                    MessageBox.Show("Выберите заем.");
                    return;
                }

                if (!decimal.TryParse(txtLoanAmount.Text, out decimal amount))
                {
                    MessageBox.Show("Сумма кредита должна быть числом.");
                    return;
                }

                if (!decimal.TryParse(txtInterestRate.Text, out decimal rate))
                {
                    MessageBox.Show("Процент должен быть числом.");
                    return;
                }

                if (cmbLoanClient.SelectedValue == null)
                {
                    MessageBox.Show("Выберите клиента.");
                    return;
                }

                if (cmbLoanManager.SelectedValue == null)
                {
                    MessageBox.Show("Выберите менеджера.");
                    return;
                }

                service.UpdateLoan(
                    selectedLoanId.Value,
                    Convert.ToInt32(cmbLoanClient.SelectedValue),
                    amount,
                    rate,
                    dtpIssueDate.Value,
                    dtpDueDate.Value,
                    txtComment.Text,
                    Convert.ToInt32(cmbLoanManager.SelectedValue));


                LoadLoans();
                ClearLoanFields();
                MessageBox.Show("Заем изменен.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteLoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedLoanId == null)
                {
                    MessageBox.Show("Выберите заем.");
                    return;
                }

                service.DeleteLoan(selectedLoanId.Value);
                LoadLoans();
                ClearLoanFields();
                MessageBox.Show("Заем удален.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshLoans_Click(object sender, EventArgs e)
        {
            LoadLoans();
            LoadLoanCombos();
        }

        private void ClearClientFields()
        {
            txtClientFullName.Clear();
            txtClientPhone.Clear();
            selectedClientId = null;
        }

        private void ClearManagerFields()
        {
            txtManagerFullName.Clear();
            txtDepartment.Clear();
            selectedManagerId = null;
        }

        private void ClearLoanFields()
        {
            txtLoanAmount.Clear();
            txtInterestRate.Clear();
            txtComment.Clear();
            dtpIssueDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now;
            selectedLoanId = null;
        }
    }
}


