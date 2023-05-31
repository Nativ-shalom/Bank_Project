using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject3
{

    [Serializable]
    public class Person
    {

        String firstname;
        String lastname;
        int age;
        String id;

        String ageString;

        public String FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }

        public String LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public String Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public String AgeString
        {
            get
            {
                return ageString;
            }
            set
            {
                ageString = value.ToString();
            }
        }

        public Person(string FName = "david", string LName = "hust", int A = 21, string ID = "123")
        {
            this.firstname = FName; //to test this. - it works with and without this.
            lastname = LName;
            age = A;
            id = ID;
        }

    }

    [Serializable]
    public class AccountMovment
    {
        int balanceDiff; //get from user
        int currBankBalance; //we calculate it
        int prevBankBalance; //get from user
        //Data data = new Data();

        String balanceDiffString;
        String currBankBalanceString;
        String prevBankBalanceString;


        public AccountMovment(int BalanceDiff, int prevBankBalance)
        {
            this.balanceDiff = BalanceDiff;
            this.prevBankBalance = prevBankBalance;
            currBankBalance = prevBankBalance + (BalanceDiff);

            balanceDiffString = BalanceDiff.ToString();
            prevBankBalanceString = prevBankBalance.ToString();
            currBankBalanceString = currBankBalance.ToString();

        }

        //we may not need a set for these arguments
        public int BalanceDiff
        {
            get
            {
                return balanceDiff;
            }
            set
            {
                balanceDiff = value;
            }
        }

        public int CurrBankBalance
        {
            get
            {
                return currBankBalance;
            }
        }

        public int PrevbankBalance
        {
            get
            {
                return prevBankBalance;
            }
            set
            {
                prevBankBalance = value;
            }
        }

        public String BalanceDiffString
        {
            get
            {
                return balanceDiffString;
            }
            set
            {
                balanceDiffString = value.ToString();
            }
        }

        public String CurrBankBalanceString
        {
            get
            {
                return currBankBalanceString;
            }
            set
            {
                currBankBalanceString = value.ToString();
            }
        }

        public String PrevBankBalanceString
        {
            get
            {
                return prevBankBalanceString;
            }
            set
            {
                prevBankBalanceString = value.ToString();
            }
        }



    }


    [Serializable]
    public class Card
    {
        static int cardNumber = 100000;
        static int cardPassword = 1000; //we can make it so the a client wants to see there card number then thay can ass the Regular Worker and then they world sen a message to the client with there card number
        static int cardCVV = 100;
        int currCardNumber;
        int currCardPassword;
        int currCardCVV;

        String currCardNumberString;
        String currCardPasswordString;
        String currCardCVVString;

        public int CardNumber //dose not need a set option cuz no one will be able to change this stuf in the card, it will be all static
        {
            get
            {
                return currCardNumber;
            }
        }

        public int CardPassword
        {
            get
            {
                return currCardPassword;
            }
        }

        public int CardCVV
        {
            get
            {
                return currCardCVV;
            }
        }

        public String CurrCardNumberString
        {
            get
            {
                return currCardNumberString;
            }
            set
            {
                currCardNumberString = value.ToString();
            }
        }

        public String CurrCardPasswordString
        {
            get
            {
                return currCardPasswordString;
            }
            set
            {
                currCardPasswordString = value.ToString();
            }
        }

        public String CurrCardCVVString
        {
            get
            {
                return currCardCVVString;
            }
            set
            {
                currCardCVVString = value.ToString();
            }
        }

        public Card()
        {
            currCardNumber = cardNumber;
            currCardPassword = cardPassword;
            currCardCVV = cardCVV;
            cardNumber++;
            cardPassword++;
            cardCVV++;
            currCardNumberString = currCardNumber.ToString();
            currCardPasswordString = currCardPassword.ToString();
            currCardCVVString = currCardCVV.ToString();
        }

        //public String CurrCardNumberString
        //{
        //    get
        //    {
        //        return currCardNumberString;
        //    }
        //    set
        //    {
        //        currCardNumberString = value.ToString();
        //    }
        //}

        //public String CurrCardPasswordString
        //{
        //    get
        //    {
        //        return currCardPasswordString;
        //    }
        //    set
        //    {
        //        currCardPasswordString = value.ToString();
        //    }
        //}

        //public String CurrCardCVVString
        //{
        //    get
        //    {
        //        return currCardCVVString;
        //    }
        //    set
        //    {
        //        currCardCVVString = value.ToString();
        //    }
        //}

    }

    [Serializable]
    public class Client : Person
    {

        //LinkedList accountMovment;

        public List<AccountMovment> accountMovment = new List<AccountMovment>();

        Card currCard = new Card();

        static int accountNumber = 100;
        int currAccountNumber;
        int bankBalance;
        //int[] accountMovement; //need to make a list of the movement of the money, mnaybe in a struct and dispay int like a sheet (like excel)
        bool isBalanceNegatieve; //if the balance is below 0 then its 0, else if its above or equal to 0 then its 1
        int accountLim;  //how low can the balance of the acllount go before the client cant use his account (cant use his card, cant draw money)
        bool isCardActive;  //if the bank balance will reach the accout lim then isCardActive will be 0, if the acount can be used the it will be 1
        int laon; //how much laon can the client take
        int mortgage; //how much mortgage can the client take

        int currLaon;
        int currMortgage;

        String currAccountNumberString;
        String bankbalanceString;
        String accountLimString;
        String laonString;
        String mortgageString;
        String currLaonString;
        String currMortgageString;

        //int yearIncome;


        //AccountMovment accountMovment; //we can make a Linke List of account movment or an array

        //AccountMovment accountMovment;


        //public LinkedList AccountMovment
        //{
        //    get
        //    {
        //        return accountMovment.head;
        //    }
        //    set
        //    {
        //        accountMovment.AttToEndofList(value);
        //    }

        //}


        public int CurrAccountNumber
        {
            get
            {
                return currAccountNumber;
            }
            set
            {
                currAccountNumber = value;
            }
        }

        public int BankBalance
        {
            get
            {
                return bankBalance;
            }
            set
            {
                //bankBalance = value;

                accountMovment.Add(new AccountMovment((bankBalance + (value)), bankBalance));
                bankBalance = value;

            }
        }

        public bool IsBalanceNegatieve
        {
            get
            {
                return isBalanceNegatieve;
            }
            set
            {
                isBalanceNegatieve = value;
            }
        }

        public int AcoountLim
        {
            get
            {
                return accountLim;
            }
            set
            {
                accountLim = value;
            }
        }

        public bool IsCardActive
        {
            get
            {
                return isCardActive;
            }
            set
            {
                isCardActive = value;
            }
        }

        public int Laon
        {
            get
            {
                return laon;
            }
            set
            {
                laon = value;
            }
        }

        public int Mortgage
        {
            get
            {
                return mortgage;
            }
            set
            {
                mortgage = value;
            }
        }

        //public int YearIncome
        //{
        //    get
        //    {
        //        return yearIncome;
        //    }
        //    set
        //    {
        //        yearIncome = value;
        //    }
        //}

        //accountMovment.addFirst(New AccountMovment(0, 0));

        public int CurrCardNumber
        {
            get
            {
                return currCard.CardNumber;
            }
        }
        public int CurrCardPassword
        {
            get
            {
                return currCard.CardPassword;
            }
        }

        public int CurrCardCVV
        {
            get
            {
                return currCard.CardCVV;
            }
        }

        public int CurrLaon
        {
            get
            {
                return currLaon;
            }
            set
            {
                currLaon = value;
            }
        }

        public int CurrMortgage
        {
            get
            {
                return currMortgage;
            }
            set
            {
                currMortgage = value;
            }
        }

        //------------------------------------------------------------------------

        public String CurrAccountNumberString
        {
            get
            {
                return currAccountNumberString;
            }
            set
            {
                currAccountNumberString = value.ToString();
            }
        }

        public String BankbalanceString
        {
            get
            {
                return bankbalanceString;
            }
            set
            {
                bankbalanceString = value.ToString();
            }
        }

        public String AccountLimString
        {
            get
            {
                return accountLimString;
            }
            set
            {
                accountLimString = value.ToString();
            }
        }

        public String LaonString
        {
            get
            {
                return laonString;
            }
            set
            {
                laonString = value.ToString();
            }
        }

        public String MortgageString
        {
            get
            {
                return mortgageString;
            }
            set
            {
                mortgageString = value.ToString();
            }
        }

        public String CurrLaonString
        {
            get
            {
                return currLaonString;
            }
            set
            {
                currLaonString = value.ToString();
            }
        }

        public String CurrMortgageString
        {
            get
            {
                return currMortgageString;
            }
            set
            {
                currMortgageString = value.ToString();
            }
        }



        public Client(string FirstName = "david", string LastName = "huzt", int Age = 21, string ID = "1234", int BankBalance = 100) //for a new Client
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.AgeString = Age.ToString();
            this.Id = ID;
            this.BankBalance = BankBalance;
            currAccountNumber = accountNumber;
            accountNumber++;
            if (BankBalance < 0)
                isBalanceNegatieve = true;
            else
                isBalanceNegatieve = false;

            accountLim = -(int)(bankBalance * 0.4);

            if (bankBalance >= accountLim)
                IsCardActive = true;
            else
                IsCardActive = false;

            //accountMovment.Add(new AccountMovment(bankBalance, 0));

            laon = bankBalance * 18;

            mortgage = bankBalance * 150;

            currLaon = 0;
            currMortgage = 0;


            CurrAccountNumberString = currAccountNumber.ToString();
            bankbalanceString = bankBalance.ToString();
            accountLimString = accountLim.ToString();
            laonString = laon.ToString();
            mortgageString = mortgage.ToString();
            currLaonString = currLaon.ToString();
            currMortgageString = currMortgage.ToString();


            accountMovment.Add(new AccountMovment(bankBalance, 0));
            accountMovment.Add(new AccountMovment(-235, accountMovment[accountMovment.Count - 1].CurrBankBalance));



        }

        //public Client (int BankBal=0, bool isBalNeg=true, int accountL=100, bool isCardAct=true, int laon=1000, int mort=1000) //  (int AccountNum=00000,         , int yearIncome)
        //{
        //    //this.accountNumber = AccountNum;
        //    currAccountNumber = accountNumber;
        //    accountNumber++;
        //    this.bankBalance = BankBal;
        //    this.isBalanceNegatieve = isBalNeg;
        //    this.accountLim = accountL;
        //    this.isCardActive = isCardAct;
        //    this.laon = laon;
        //    this.mortgage = mort;
        //    //this.yearIncome = yearIncome;

        //}

        //public Client(int bankBalance=0) //(int accountNum=00000, 
        //{
        //    //this.accountNumber = accountNum;
        //    currAccountNumber = accountNumber;
        //    accountNumber++;
        //    this.bankBalance = bankBalance;

        //    if (bankBalance < 0)
        //        isBalanceNegatieve = true;
        //    else
        //        isBalanceNegatieve = false;

        //    //this.accountLim = maxBalance(accountMovment); //need to make a list for the accountMovment and then based on the max income we calc the accountLim


        //    //accountLim = -(int)(bankBalance * 0.4);
        //    //accountLim = -(int)((AccountMovment.MaxBalance) * 0.4);
        //    accountLim = -(int)(bankBalance * 0.4);

        //    IsCardActive = true;


        //    laon = bankBalance * 18; //we can change it to make it that the laon amount change's depens on the amount in the bank

        //    mortgage = bankBalance * 150; //we can to the same as the laon

        //}


        //need to add function that allow to change the loan, accoutLim and mortgage manualy.


        public void AddToAccountMovment(int BalanceDiff) //need a method to add the movmewnt to the list
        {
            AccountMovment a = new AccountMovment(BalanceDiff, accountMovment[accountMovment.Count-1].CurrBankBalance);
            accountMovment.Add(a);

        }

    }



    [Serializable]
    public class Worker : Person
    {

        public static int workerNumber = 1000;
        int currWorkNumber;
        int seniority; //וותק
        string workCity;
        //every worker can also see the card information, if we do add card
        //every worker can see the account balance basd on the account number

        int salary;

        int yearSalary;

        String currWorkNumberString;
        String seniorityString;
        String salaryString;
        String yearSalaryString;

        //public void SeeAccountNumber(int accountNumber) //see bankBalance
        //{

        //}

        //getter & setter
        public int Seniority
        {
            get
            {
                return seniority;
            }
            set
            {
                seniority = value;
            }
        }

        public string WorkCity
        {
            get
            {
                return workCity;
            }
            set
            {
                workCity = value;
            }
        }

        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        //public string SalaryString
        //{
        //    get
        //    {
        //        return salary.ToString();
        //    }
        //}
        // public string CurrStringWorkNumber
        //{
        //    get
        //    {
        //        return currWorkNumber.ToString();
        //    }
        //}

        public int CurrWorkNumber
        {
            get
            {
                return currWorkNumber;
            }
            set
            {
                if (value > 1 || value < 0)
                {
                    workerNumber++;
                }
                workerNumber++;
            }
        }



        public int YearSalary
        {
            get
            {
                return yearSalary;
            }
            set
            {
                yearSalary = salary * 12;
            }
        }

        //public string YearSalaryString
        //{
        //    get
        //    {
        //        return yearSalary.ToString();
        //    }
        //}

        public String CurrWorkNumberString
        {
            get
            {
                return currWorkNumberString;
            }
            set
            {
                currWorkNumberString = value.ToString();
            }
        }

        public String SeniorityString
        {
            get
            {
                return salaryString;
            }
            set
            {
                salaryString = value.ToString();
            }
        }

        public String SalaryString
        {
            get
            {
                return salaryString;
            }
            set
            {
                salaryString = value.ToString();
            }
        }

        public String YearSalaryString
        {
            get
            {
                return yearSalaryString;
            }
            set
            {
                yearSalaryString = value.ToString();
            }
        }


        public Worker(string FirstName = "david", string LastName = "huzt", int Age = 21, string Id = "1234", int seniority = 0, string workCity = "bat-yam", int salary = 8000) //for a new worker
        {
            currWorkNumber = workerNumber;
            workerNumber++;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.AgeString = Age.ToString();
            this.Id = Id;
            this.seniority = seniority;
            this.workCity = workCity;
            this.salary = salary;
            this.yearSalary = salary * 12;

            currWorkNumberString = currWorkNumber.ToString();
            seniorityString = seniority.ToString();
            salaryString = salary.ToString();
            yearSalaryString = (salary * 12).ToString();
        }

        //public Worker(int seniority = 0, string workCity="bat-yam", int salary=8000)
        //{
        //    currWorkNumber = workerNumber;
        //    this.seniority = seniority;
        //    this.workCity = workCity;
        //    this.salary = salary;
        //}

        //we can add a Deposit function to all the workers but the regularworker can only deposit to a max of 5000 (we can change the value),
        //and the hightworker can deposit any amount of money to the account of the client


        //public int ViewSalary(int accountNumber)
        //{
        //    Client temp = new Client();

        //    int salaryTemp;
        //    salaryTemp=temp.ac
        //}


    }

    [Serializable]
    public class RegularWorker : Worker
    {

        //seeIsNegatieve-can see if the client in a minus or not (based on the accountNumber)

        //OpenNewBankAccount-can open a new account for a new client

        //seeIsCardActive-can see if the card is active or not for the client, (based on the accountNumber)

        //giveNewCard-can give a new card for a customer

        //public void OpenNewClient()

        //int RworkeNumber;
        //int Rsalary;
        //int Rseniority;

        //public int RWorkeNumber
        //{
        //    get
        //    {
        //        return RworkeNumber;
        //    }
        //}

        //public int RSalary
        //{
        //    get
        //    {
        //        return Rsalary;
        //    }
        //}

        //public int RSeniority
        //{
        //    get
        //    {
        //        return Rseniority;
        //    }
        //    set
        //    {
        //        Rseniority = value;
        //        Rsalary = Rsalary + (1000 * value);
        //    }
        //}


        //public RegularWorker(string FirstName = "david", string LastName = "huzt", int Age = 21, string Id = "1234", int Rseniority = 0, string workCity = "bat-yam", int Rsalary = 8000) //for a new worker
        //{
        //    RworkeNumber = CurrWorkNumber;

        //    this.FirstName = FirstName;
        //    this.LastName = LastName;
        //    this.Age = Age;
        //    this.Id = Id;

        //    //this.seniority = seniority;
        //    //this.workCity = workCity;
        //    //this.salary = salary;

        //    this.Rsalary = Rsalary;
        //    this.Rseniority = Rseniority;

        //}

        //bool isEligible = false;

        //public bool IsEligible
        //{
        //    get
        //    {
        //        return IsEligible;
        //    }
        //}

        public RegularWorker(string FirstName = "david", string LastName = "huzt", int Age = 21, string Id = "1234", int seniority = 0, string workCity = "bat-yam", int salary = 8000)
        {
            CurrWorkNumber = workerNumber;
            CurrWorkNumber++; // or workerNumber++;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Id = Id;
            this.Seniority = seniority;
            this.WorkCity = workCity;
            this.Salary = salary;
            this.YearSalary = salary * 12;
            //isEligible = false;

            this.CurrWorkNumberString = CurrWorkNumber.ToString();
            this.SeniorityString = seniority.ToString();
            this.SalaryString = salary.ToString();
            this.YearSalaryString = (salary * 12).ToString();
        }


    }


    public class SeniorEmployee : Worker
    {

        //probeble make it so every worker can see the bankBalance of the client (based on the account number)

        //seeAccountMovement-can see the accountmovment of the account (based on the account number)

        //seeLaon-can see how much laon can the client take, and can manualy change it (based on the account number)

        //seeMortgage-can see how much mortgage can the client take and can change it manuale (based on the account number)

        //bool isEligible = true;

        //public bool IsEligible
        //{
        //    get
        //    {
        //        return IsEligible;
        //    }
        //}

        public SeniorEmployee(string FirstName = "david", string LastName = "huzt", int Age = 21, string Id = "1234", int seniority = 0, string workCity = "bat-yam", int salary = 8000)
        {
            CurrWorkNumber = workerNumber;
            CurrWorkNumber++; // or workerNumber++; // if we do (workerNumber-999) so that the SeniorEmployee will have a worke number betwen 1 and 1000, then we dont need to move the workenumber by 1
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Id = Id;
            this.Seniority = seniority;
            this.WorkCity = workCity;
            this.Salary = salary;
            this.YearSalary = salary * 12;
            //isEligible = true;

            this.CurrWorkNumberString = CurrWorkNumber.ToString();
            this.SeniorityString = seniority.ToString();
            this.SalaryString = salary.ToString();
            this.YearSalaryString = (salary * 12).ToString();
        }



    }







}
