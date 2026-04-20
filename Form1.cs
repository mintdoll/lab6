using System;
using System.Windows.Forms;
using MicrofinanceApp.Factories;
using MicrofinanceApp.Models;
using MicrofinanceApp.Services;

namespace MicrofinanceApp
{
    public partial class Form1 : Form
    {
        private MicrofinanceCompany company;
        private XmlDataService dataService;
        private LoanFactory loanFactory;
        private string filePath = "data.xml";

        public Form1()
        {
            InitializeComponent();

            company = new MicrofinanceCompany();
            dataService = new XmlDataService();
            loanFactory = new LoanFactory();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeManagers();
            RefreshGrid();
        }

        private void InitializeManagers()
        {
            if (company.Managers.Count == 0)
            {
                company.AddManager(new Manager(1, "Иванов И.И.", "Отдел микрозаймов"));
                company.AddManager(new Manager(2, "Петров П.П.", "Кредитный отдел"));
                company.AddManager(new Manager(3, "Сидорова А.А.", "Работа с клиентами"));
            }

            cmbManager.DataSource = null;
            cmbManager.DataSource = company.Managers;
            cmbManager.DisplayMember = "FullName";
        }

        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtClientName.Text))
                {
                    MessageBox.Show("Введите ФИО клиента.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show("Введите телефон клиента.");
                    return;
                }

                decimal amount = decimal.Parse(txtAmount.Text);
                double interestRate = double.Parse(txtInterestRate.Text);

                Client client = new Client(
                    company.Clients.Count + 1,
                    txtClientName.Text,
                    txtPhone.Text);

                company.AddClient(client);

                Manager manager = (Manager)cmbManager.SelectedItem;

                Loan loan = loanFactory.CreateLoan(
                    company.Loans.Count + 1,
                    amount,
                    interestRate,
                    dtpIssueDate.Value,
                    dtpDueDate.Value,
                    txtComment.Text,
                    client,
                    manager);

                company.AddLoan(loan);

                RefreshGrid();
                ClearForm();
                decimal totalAmount = loan.CalculateTotalAmount();
                MessageBox.Show($"Кредит успешно добавлен. Итог к возврату: {totalAmount}");

            }
            catch
            {
                MessageBox.Show("Проверьте правильность введенных данных.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataService.SaveToXml(filePath, company);
            MessageBox.Show("Данные сохранены в XML.");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            company = dataService.LoadFromXml(filePath);
            InitializeManagers();
            RefreshGrid();
            MessageBox.Show("Данные загружены из XML.");
        }

        private void RefreshGrid()
        {
            dgvLoans.DataSource = null;
            dgvLoans.DataSource = company.Loans;
        }

        private void ClearForm()
        {
            txtClientName.Clear();
            txtPhone.Clear();
            txtAmount.Clear();
            txtInterestRate.Clear();
            txtComment.Clear();
            dtpIssueDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now;
            cmbManager.SelectedIndex = 0;
        }
    }
}
