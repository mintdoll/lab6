using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MicrofinanceApp.Data;
using MicrofinanceApp.Models;

namespace MicrofinanceApp.Services
{
    public class CrudService
    {
        private static void ValidateFullName(string fullName, string message)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException(message);

            if (fullName.Any(char.IsDigit))
                throw new ArgumentException("ФИО не может содержать цифры.");
        }

        private static void SaveChanges(AppDbContext db)
        {
            try
            {
                db.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                throw new InvalidOperationException("Не удалось сохранить изменения. Возможно, нарушена целостность данных.", ex);
            }
            catch (System.Data.Entity.Core.EntityException ex)
            {
                throw new InvalidOperationException("Не удалось подключиться к базе данных.", ex);
            }
        }

        // --------------------
        // CLIENTS
        // --------------------

        public List<Client> GetClients()
        {
            using (var db = new AppDbContext())
            {
                return db.Clients
                    .OrderBy(x => x.FullName)
                    .ToList();
            }
        }

        public void AddClient(string fullName, string phone)
        {
            ValidateFullName(fullName, "Введите ФИО клиента.");

            if (string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException("Введите телефон клиента.");

            using (var db = new AppDbContext())
            {
                var client = new Client
                {
                    FullName = fullName.Trim(),
                    Phone = phone.Trim()
                };

                db.Clients.Add(client);
                SaveChanges(db);
            }
        }

        public void UpdateClient(int id, string fullName, string phone)
        {
            ValidateFullName(fullName, "Введите ФИО клиента.");

            if (string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException("Введите телефон клиента.");

            using (var db = new AppDbContext())
            {
                var client = db.Clients.FirstOrDefault(x => x.Id == id);
                if (client == null)
                    throw new InvalidOperationException("Клиент не найден.");

                client.FullName = fullName.Trim();
                client.Phone = phone.Trim();

                SaveChanges(db);
            }
        }

        public void DeleteClient(int id)
        {
            using (var db = new AppDbContext())
            {
                var client = db.Clients.FirstOrDefault(x => x.Id == id);
                if (client == null)
                    throw new InvalidOperationException("Клиент не найден.");

                if (db.Loans.Any(x => x.ClientId == id))
                    throw new InvalidOperationException("Нельзя удалить клиента, так как у него есть связанные займы.");

                db.Clients.Remove(client);
                SaveChanges(db);
            }
        }

        // --------------------
        // MANAGERS
        // --------------------

        public List<Manager> GetManagers()
        {
            using (var db = new AppDbContext())
            {
                return db.Managers
                    .OrderBy(x => x.FullName)
                    .ToList();
            }
        }

        public void AddManager(string fullName, string department)
        {
            ValidateFullName(fullName, "Введите ФИО менеджера.");

            if (string.IsNullOrWhiteSpace(department))
                throw new ArgumentException("Введите отдел.");

            using (var db = new AppDbContext())
            {
                var manager = new Manager
                {
                    FullName = fullName.Trim(),
                    Department = department.Trim()
                };

                db.Managers.Add(manager);
                SaveChanges(db);
            }
        }

        public void UpdateManager(int id, string fullName, string department)
        {
            ValidateFullName(fullName, "Введите ФИО менеджера.");

            if (string.IsNullOrWhiteSpace(department))
                throw new ArgumentException("Введите отдел.");

            using (var db = new AppDbContext())
            {
                var manager = db.Managers.FirstOrDefault(x => x.Id == id);
                if (manager == null)
                    throw new InvalidOperationException("Менеджер не найден.");

                manager.FullName = fullName.Trim();
                manager.Department = department.Trim();

                SaveChanges(db);
            }
        }

        public void DeleteManager(int id)
        {
            using (var db = new AppDbContext())
            {
                var manager = db.Managers.FirstOrDefault(x => x.Id == id);
                if (manager == null)
                    throw new InvalidOperationException("Менеджер не найден.");

                if (db.Loans.Any(x => x.ManagerId == id))
                    throw new InvalidOperationException("Нельзя удалить менеджера, так как у него есть связанные займы.");

                db.Managers.Remove(manager);
                SaveChanges(db);
            }
        }

        // --------------------
        // LOANS
        // --------------------

        public List<Loan> GetLoans()
        {
            using (var db = new AppDbContext())
            {
                return db.Loans
                    .Include(x => x.Client)
                    .Include(x => x.Manager)
                    .OrderByDescending(x => x.Id)
                    .ToList();
            }
        }

        public void AddLoan(
            int clientId,
            decimal amount,
            decimal interestRate,
            DateTime issueDate,
            DateTime dueDate,
            string comment,
            int managerId)
        {
            if (clientId <= 0)
                throw new ArgumentException("Выберите клиента.");

            if (amount <= 0)
                throw new ArgumentException("Сумма кредита должна быть больше нуля.");

            if (interestRate <= 0)
                throw new ArgumentException("Процентная ставка должна быть больше нуля.");

            if (dueDate.Date < issueDate.Date)
                throw new ArgumentException("Дата погашения не может быть раньше даты выдачи.");

            using (var db = new AppDbContext())
            {
                var client = db.Clients.FirstOrDefault(x => x.Id == clientId);
                if (client == null)
                    throw new InvalidOperationException("Клиент не найден.");

                var manager = db.Managers.FirstOrDefault(x => x.Id == managerId);
                if (manager == null)
                    throw new InvalidOperationException("Менеджер не найден.");

                var loan = new Loan(
                    amount,
                    interestRate,
                    issueDate.Date,
                    dueDate.Date,
                    comment?.Trim(),
                    client,
                    manager);

                db.Loans.Add(loan);
                SaveChanges(db);
            }
        }

        public void UpdateLoan(
            int loanId,
            int clientId,
            decimal amount,
            decimal interestRate,
            DateTime issueDate,
            DateTime dueDate,
            string comment,
            int managerId)
        {
            if (clientId <= 0)
                throw new ArgumentException("Выберите клиента.");

            if (amount <= 0)
                throw new ArgumentException("Сумма кредита должна быть больше нуля.");

            if (interestRate <= 0)
                throw new ArgumentException("Процентная ставка должна быть больше нуля.");

            if (dueDate.Date < issueDate.Date)
                throw new ArgumentException("Дата погашения не может быть раньше даты выдачи.");

            using (var db = new AppDbContext())
            {
                var loan = db.Loans
                    .Include(x => x.Client)
                    .Include(x => x.Manager)
                    .FirstOrDefault(x => x.Id == loanId);

                if (loan == null)
                    throw new InvalidOperationException("Заем не найден.");

                var client = db.Clients.FirstOrDefault(x => x.Id == clientId);
                if (client == null)
                    throw new InvalidOperationException("Клиент не найден.");

                var manager = db.Managers.FirstOrDefault(x => x.Id == managerId);
                if (manager == null)
                    throw new InvalidOperationException("Менеджер не найден.");

                loan.Amount = amount;
                loan.InterestRate = interestRate;
                loan.IssueDate = issueDate.Date;
                loan.DueDate = dueDate.Date;
                loan.Comment = comment?.Trim();
                loan.Client = client;
                loan.ClientId = client.Id;
                loan.Manager = manager;
                loan.ManagerId = manager.Id;

                SaveChanges(db);
            }
        }

        public void DeleteLoan(int id)
        {
            using (var db = new AppDbContext())
            {
                var loan = db.Loans.FirstOrDefault(x => x.Id == id);
                if (loan == null)
                    throw new InvalidOperationException("Заем не найден.");

                db.Loans.Remove(loan);
                SaveChanges(db);
            }
        }
    }
}

