using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;


namespace BankManagementProject
{
    public delegate void DWidnowClose();
    public class AccountViewModel : INotifyPropertyChanged
    {
        public DWidnowClose NewWindowClose;
        public DWidnowClose EditWindowClose;
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _accountNumber;
        public int AccountNumber
        {
            get { return _accountNumber; }
            set
            {
                _accountNumber = value;
                OnPropertyChanged(nameof(AccountNumber));
            }

        }

        private int _amount;

        public int Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }

        private AccountModel _newAccount = null;
        public AccountModel NewAccount
        {
            get => _newAccount;
            set { _newAccount = value; OnPropertyChanged(nameof(NewAccount)); }
        }
        //
        private AccountModel _selectedAccount = null;
        public AccountModel SelectedAccount
        {
            get => _selectedAccount;
            set { _selectedAccount = value; OnPropertyChanged(nameof(SelectedAccount)); }
        }
        

        private IAccountRepo _repo = new AccountMemoryRepo();

        private ObservableCollection<AccountModel> _accounts;
        public ObservableCollection<AccountModel> Accounts
        {
            get 
            {
                if (_accounts == null)
                {
                    _accounts = _repo.ReadAllAccount();
                }
                return _accounts;
            }
            set
            {
                _accounts = value;
                OnPropertyChanged(nameof(Accounts));
                OnPropertyChanged(nameof(FilteredAccounts));
            }
        }


        private string _selectedFilter;
        public string SelectedFilter
        {
            get { return _selectedFilter; }
            set
            {
                _selectedFilter = value;
                OnPropertyChanged(nameof(SelectedFilter));
                OnPropertyChanged(nameof(FilteredAccounts));
            }
        }

        //public ObservableCollection<AccountModel> FilteredAccounts
        //{
        //    get
        //    {
        //        if (string.IsNullOrEmpty(SelectedFilter) || SelectedFilter == "All")
        //            return Accounts;
        //        else if (SelectedFilter == "Savings")
        //            return new ObservableCollection<AccountModel>(Accounts.Where(a => a.AccType == "Savings"));
        //        else if (SelectedFilter == "Current")
        //            return new ObservableCollection<AccountModel>(Accounts.Where(a => a.AccType == "Current"));
        //        else
        //            return new ObservableCollection<AccountModel>();
        //    }
        //}

        public ObservableCollection<AccountModel> FilteredAccounts
        {
            get
            {
                if (string.IsNullOrEmpty(SelectedFilter) || SelectedFilter == "All")
                    return Accounts;
                else if (SelectedFilter == "Savings")
                    return new ObservableCollection<AccountModel>(Accounts.Where(a => string.Equals(a.AccType, "savings", StringComparison.OrdinalIgnoreCase)));
                else if (SelectedFilter == "Current")
                    return new ObservableCollection<AccountModel>(Accounts.Where(a => string.Equals(a.AccType, "current", StringComparison.OrdinalIgnoreCase)));
                else
                    return new ObservableCollection<AccountModel>();
            }
        }



        //public ObservableCollection<AccountModel> Accounts
        //{
        //    get
        //    {
        //        return _repo.ReadAllAccount();
        //    }
        //}

        public ICommand CreateCommand { get; }
        public ICommand UpdateCommand { get; }
        public ICommand DeleteCommand { get; }

        public ICommand WithdrawCommand { get; }
        public ICommand DepositCommand { get; }

        
        public AccountViewModel()
        {
            this.NewAccount = new AccountModel
            {
                AccNo = 0,
                Name = "",
                Balance = 0,
                AccType = "savings",
                Email = " sample@gmail.com",
                PhNo = "xxxx-xxxx",
                Address = "",
                IsActive = true,
                InterestPercentage = "0",
                TransactionCount = 0,
                LastTransactionDate = DateTime.Now
            };

            

            CreateCommand = new RelayCommand(Create);
            UpdateCommand = new RelayCommand(Update);
            DeleteCommand = new RelayCommand(Delete);
            WithdrawCommand = new RelayCommand(Withdraw);
            DepositCommand = new RelayCommand(Deposit);
        }

        

        public void Create()
        {
            AccountModel newAccount = new AccountModel
            {
                AccNo = NewAccount.AccNo,
                Name = NewAccount.Name,
                Balance = NewAccount.Balance,
                AccType = NewAccount.AccType,
                Email = NewAccount.Email,
                PhNo = NewAccount.PhNo,
                Address = NewAccount.Address,
                IsActive = NewAccount.IsActive,
                InterestPercentage = NewAccount.InterestPercentage,
                TransactionCount = NewAccount.TransactionCount,
                LastTransactionDate = NewAccount.LastTransactionDate
            };
            var result = MessageBox.Show(messageBoxText: "Are you sure to create?",
                    caption: "Confirm",
                    button: MessageBoxButton.YesNo,
                    icon: MessageBoxImage.Question);
            if (result != MessageBoxResult.Yes)
            {
                return;
            }
            _repo.Create(newAccount);
            this.NewAccount = new AccountModel { AccNo = 0, Name = "", Balance = 0, AccType = "", Email = "", PhNo = "", Address = "", IsActive = false, InterestPercentage = "0", TransactionCount = 0, LastTransactionDate = DateTime.Now };
            
            result = MessageBox.Show(messageBoxText: "Created Successfully",
                    caption: "Alert",
                    button: MessageBoxButton.OK,
                    icon: MessageBoxImage.Information);

            if (NewWindowClose != null)
            {
                NewWindowClose();
            }
        }

        public void Update()
        {
            if (this.SelectedAccount == null)
            {
                return;
            }

            _repo.UpdateAccount(this.SelectedAccount);
            this.SelectedAccount = this.SelectedAccount;
            var result = MessageBox.Show(messageBoxText: "Updated Successfully",
                    caption: "Alert",
                    button: MessageBoxButton.OK,
                    icon: MessageBoxImage.Information);

            if (EditWindowClose != null)
            {
                EditWindowClose();
            }
        }
        public void Delete()
        {
            if (this.SelectedAccount == null)
            {
                return;
            }
            this.Accounts.Remove(this.SelectedAccount);
            this.SelectedAccount = null;
        }
        public void Withdraw()
        {
            var result = MessageBox.Show(messageBoxText: "Are you sure to Withdraw?",
                   caption: "Confirm",
                   button: MessageBoxButton.YesNo,
                   icon: MessageBoxImage.Question);
            if (result != MessageBoxResult.Yes)
            {
                return;
            }
            _repo.Withdraw(AccountNumber, Amount);
            this.AccountNumber = 0;
            this.Amount = 0;
        }
        public void Deposit()
        {
            var result = MessageBox.Show(messageBoxText: "Are you sure to Deposit?",
                   caption: "Confirm",
                   button: MessageBoxButton.YesNo,
                   icon: MessageBoxImage.Question);
            if (result != MessageBoxResult.Yes)
            {
                return;
            }
            _repo.Deposit(AccountNumber, Amount);


            this.AccountNumber = 0;
            this.Amount = 0;
        }

    }

}